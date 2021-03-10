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

namespace Reminder
{
    public partial class Form1 : Form
    {
        public string apiURL = "http://www.omdbapi.com/?apikey=1574810&";

        int currentPageIndex = 1;
        int totalPages = 1;

        public class SearchResults
        {
            public List<Titles> Search { get; set; }
            public string totalResults { get; set; }
            public bool Response { get; set; }
        }

        public class Titles
        {
            public string Title { get; set; }
            public string Year { get; set; }
            public string imdbID { get; set; }
            public string Type { get; set; }
            public string Poster { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            ResetSearch();
        }

        private void ResetSearch()
        {
            searchResults.Items.Clear();
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
            var json = client.GetStringAsync(CreateURL(false, searchResults.SelectedItems[0].SubItems[2].Text, 1));
            var results = JsonConvert.DeserializeObject(json.Result);
            MessageBox.Show(results.ToString());
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchTxtBox.Text != null)
            {

                HttpClient client = new HttpClient();
                var json = client.GetStringAsync(CreateURL(true, SearchTxtBox.Text, 1));
                var results = JsonConvert.DeserializeObject<SearchResults>(json.Result);

                totalPages = Convert.ToInt32(results.totalResults) / 10;
                resultsTotalLabel.Text = currentPageIndex + "/" + totalPages + " Pages";

                foreach (Titles result in results.Search)
                {
                    ListViewItem item = new ListViewItem(result.Title);
                    item.SubItems.Add(result.Year);
                    item.SubItems.Add(result.imdbID);
                    item.SubItems.Add(result.Type);
                    item.SubItems.Add(result.Poster);
                    searchResults.Items.Add(item);
                }
            }
        }
    }
}
