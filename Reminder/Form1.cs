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

namespace Reminder
{
    public partial class Form1 : Form
    {
        public string apiURL = "http://www.omdbapi.com/?apikey=1574810&";

        int currentPageIndex = 1;
        int totalPages = 1;

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
            string resultsString = "";
            HttpClient client = new HttpClient();
            foreach (ListViewItem item in ((ListView)sender).SelectedItems)
            {
                var json = client.GetStringAsync(CreateURL(false, ((Result)item.Tag).imdbID, 1));
                var results = JsonConvert.DeserializeObject(json.Result);

                resultsString += System.Environment.NewLine;
                resultsString += System.Environment.NewLine;
                resultsString += "-----------------NEXT MOVIE-----------------";
                resultsString += System.Environment.NewLine;
                resultsString += System.Environment.NewLine;

                resultsString += results.ToString().Trim();
            }
            MessageBox.Show(resultsString);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void SearchTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                Search();
            }
        }

        private void Search()
        {
            if (SearchTxtBox.Text != null)
            {
                HttpClient client = new HttpClient();
                var json = client.GetStringAsync(CreateURL(true, SearchTxtBox.Text, 1));
                var results = JsonConvert.DeserializeObject<Results>(json.Result);

                totalPages = Convert.ToInt32(results.totalResults) / 10;
                resultsTotalLabel.Text = currentPageIndex + "/" + totalPages + " Pages";

                foreach (Result result in results.Search)
                {
                    ListViewItem item = new ListViewItem(result.Title);
                    item.SubItems.Add(result.Year);
                    item.SubItems.Add(result.imdbID);
                    item.SubItems.Add(result.Type);
                    item.SubItems.Add(result.Poster);
                    searchResults.Items.Add(item);

                    item.Tag = result;
                }
            }
        }
    }
}
