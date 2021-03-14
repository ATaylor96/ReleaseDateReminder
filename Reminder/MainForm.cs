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

        public MainForm()
        {
            InitializeComponent();
            ResetSearch();
        }

        private void ResetSearch()
        {
            flowLayoutPanel1.Controls.Clear();
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
                flowLayoutPanel1.Controls.Clear();

                HttpClient client = new HttpClient();
                var json = client.GetStringAsync(CreateURL(true, SearchTxtBox.Text, pageNum));
                var results = JsonConvert.DeserializeObject<SearchResults>(json.Result);

                totalPages = (int)Math.Ceiling(Convert.ToDouble(results.totalResults) / (double)10);
                resultsTotalLabel.Text = currentPageIndex + "/" + totalPages.ToString() + " Pages";

                if (Convert.ToInt32(results.totalResults) > 0)
                {
                    foreach (SearchResult result in results.Search)
                    {
                        TitlePanel titlePanel = new TitlePanel(result, this);
                        titlePanel.Tag = result;
                        flowLayoutPanel1.Controls.Add(titlePanel);
                    }
                }
                else { ResetSearch(); }
            }
            else
            {
                MessageBox.Show("Search box is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void LoadDetails(SearchResult result)
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync(CreateURL(false, result.imdbID, 1));
            Movie movie = JsonConvert.DeserializeObject<Movie>(json.Result);
            if (movie != null)
            {
                tabControl1.SelectedTab = tabPage2;
                tabPage2.Text = movie.Title;
                titleLabel.Text = movie.Title;
                yearLabel.Text = movie.Year;
                runtimeLabel.Text = movie.Runtime;
                ratingLabel.Text = movie.Year;
                plotLabel.Text = movie.Plot;
            }
            else { MessageBox.Show("Could not received movie details."); }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < totalPages)
            {
                currentPageIndex++;
                resultsTotalLabel.Text = currentPageIndex + "/" + totalPages + " Pages";
                Search(currentPageIndex);
                if (currentPageIndex == totalPages) { ((Button)sender).Enabled = false; }
                backBtn.Enabled = true;
            }
            else { MessageBox.Show("No more pages"); }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                resultsTotalLabel.Text = currentPageIndex + "/" + totalPages + " Pages";
                Search(currentPageIndex);
                if (currentPageIndex == 1) { ((Button)sender).Enabled = false; }
                nextBtn.Enabled = true;
            }
            else { MessageBox.Show("No more pages"); }
        }


    }
}
