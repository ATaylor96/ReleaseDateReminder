using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;
using Reminder.Classes;
using System.Net;
using System.IO;
using System.Reflection;

namespace Reminder
{
    public partial class MainForm : Form
    {
        public string apiURL = "http://www.omdbapi.com/?apikey=1574810&";

        int currentPageIndex = 1;
        int totalPages = 1;

        List<Control> detailControls = new List<Control>();

        public MainForm()
        {
            InitializeComponent();
            foreach (Control c in tabPage2.Controls)
            {
                detailControls.Add(c);
            }
            tabControl1.TabPages.Remove(tabPage2);
            ResetSearch();
        }

        private void ResetSearch()
        {
            searchResultsListView.Items.Clear();
            SearchTxtBox.Text = null;
            resultsTotalLabel.Text = null;
        }

        public string CreateURL(bool isSearch, string titleRequested, int pageNumber)
        {
            string url = apiURL;
            if (isSearch)
            {
                url += "s=" + titleRequested + "&page=" + pageNumber;
            }
            else
            {
                url += "i=" + titleRequested;
            }

            url += "&r=json";

            return url;
        }

        private void searchResults_ItemActivate(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            foreach (ListViewItem item in ((ListView)sender).SelectedItems)
            {
                var json = client.GetStringAsync(CreateURL(false, ((SearchResult)item.Tag).imdbID, 1));
                if (((SearchResult)item.Tag).Type == "movie")
                {
                    LoadMovieDetails(JsonConvert.DeserializeObject<Movie>(json.Result));
                }
                else if (((SearchResult)item.Tag).Type == "series")
                {
                    LoadShowDetails(JsonConvert.DeserializeObject<TVShow>(json.Result));
                }
                else { }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search(1);
            currentPageIndex = 1;
        }

        private void SearchTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                Search(1);
                currentPageIndex = 1;
            }
        }
        
        private void Search(int pageNum)
        {
            if (!String.IsNullOrWhiteSpace(SearchTxtBox.Text))
            {
                searchResultsListView.Items.Clear();

                HttpClient client = new HttpClient();
                var json = client.GetStringAsync(CreateURL(true, SearchTxtBox.Text, pageNum));
                var results = JsonConvert.DeserializeObject<SearchResults>(json.Result);

                totalPages = (int)Math.Ceiling(Convert.ToDouble(results.totalResults) / (double)10);
                resultsTotalLabel.Text = currentPageIndex + "/" + totalPages.ToString() + " Pages";

                if (Convert.ToInt32(results.totalResults) > 0)
                {
                    foreach (SearchResult result in results.Search)
                    {
                        ListViewItem item = new ListViewItem(result.Title);
                        item.SubItems.Add(result.Year);
                        item.SubItems.Add(result.imdbID);
                        item.SubItems.Add(result.Type);
                        item.SubItems.Add(result.Poster);
                        searchResultsListView.Items.Add(item);
                        item.Tag = result;
                    }
                }
                else { ResetSearch(); }
            }
            else
            {
                MessageBox.Show("Search box is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadMovieDetails(Movie movie)
        {
            TabPage tab = new TabPage(movie.Title);
            tabControl1.TabPages.Add(tab);
            foreach (Control c in detailControls)
            {
                tab.Controls.Add(c);
            }
            //tab.Controls.AddRange(detailControls.ToArray());
            tabControl1.SelectedTab = tab;
        }

        private object CloneTab(object o)
        {
            Type t = o.GetType();
            PropertyInfo[] properties = t.GetProperties();

            Object p = t.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, o, null);

            foreach (PropertyInfo pi in properties)
            {
                if (pi.CanWrite)
                {
                    pi.SetValue(p, pi.GetValue(o, null), null);
                }
            }

            return p;
        }

        private void LoadShowDetails(TVShow show)
        {
            TabPage tab = new TabPage(show.Title);
            tabControl1.TabPages.Add(tab);

            foreach (Control c in detailControls)
            {
                tab.Controls.Add(c);
            }
            //tab.Controls.AddRange(detailControls.ToArray());
            tabControl1.SelectedTab = tab;

            //((PictureBox)tab.Controls.Find("pictureBox1", false)[0]).Load(show.Poster);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPageIndex + 1 < totalPages)
            {
                currentPageIndex++;
                backBtn.Enabled = true;
                Search(currentPageIndex);
                resultsTotalLabel.Text = currentPageIndex + "/" + totalPages + " Pages";
            }
            else { nextBtn.Enabled = false; }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (currentPageIndex - 1 > 1)
            {
                currentPageIndex--;
                nextBtn.Enabled = true;
                Search(currentPageIndex);
                resultsTotalLabel.Text = currentPageIndex + "/" + totalPages + " Pages";
            }
            else { backBtn.Enabled = false; }
        }
    }
}
