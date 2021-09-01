using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Reminder.Classes;
using System.Threading.Tasks;

namespace Reminder
{
    public partial class MainForm : Form
    {
        // rawg api key - e7cb6ac232454c8c9b5211b61d6a1cc0

        public string apiURL = "http://www.omdbapi.com/?apikey=1574810&";
        public string igdbApiURL = "https://id.twitch.tv/oauth2/token?client_id=k4t0wyx0m80xtmdokvzcatextvrrfe&client_secret=m9hzzyf551h0w51wukahw91jm5j19t&grant_type=client_credentials";

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
                        TitlePanel titlePanel = new TitlePanel(this, result) { Tag = result };
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
            Clipboard.SetText(CreateURL(false, result.imdbID, 1));
            Movie movie = JsonConvert.DeserializeObject<Movie>(json.Result);
            if (movie != null)
            {
                TabPage tab = new TabPage(movie.Title) { Tag = movie };
                MovieDetailsPanel panel = new MovieDetailsPanel(this, movie) { Tag = tab };
                panel.Dock = DockStyle.Fill;
                tab.Controls.Add(panel);
                tabControl1.TabPages.Add(tab);
                tabControl1.SelectedTab = tab;
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var results = GetGameList(textBox1.Text, 1);
            foreach (GameSearchResult result in results.results)
            {
                textBox2.Text += result.name + ": " + result.id.ToString() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var results = GetGameDetails(textBox1.Text, 1);
            textBox2.Text = results;
        }

        private GameSearchResults GetGameList(string searchTerm, int page)
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync("https://api.rawg.io/api/games?key=e7cb6ac232454c8c9b5211b61d6a1cc0" + "&page=" + page + "&search=" + searchTerm);
            var results = JsonConvert.DeserializeObject<GameSearchResults>(json.Result);
            return results;
        }

        private string GetGameDetails(string searchTerm, int page)
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync("https://api.rawg.io/api/games/" + searchTerm + "?key=e7cb6ac232454c8c9b5211b61d6a1cc0");
            var results = JsonConvert.DeserializeObject(json.Result).ToString();
            return results;
        }
    }
}
