using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using ReminderUI.Classes.RAWG.Models;
using ReminderUI.Classes.TMDB.Models;

namespace ReminderUI
{
    public partial class TestSearchForm : Form
    {
        TestForm mainForm;

        public TestSearchForm(TestForm f)
        {
            InitializeComponent();
            mainForm = f;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchListView.Items.Clear();
            if (moviesCheckBox.Checked)
            {
                var s = SearchMovies(searchTextBox.Text);

                foreach (TMDBSearchModels.MovieResults movie in s.results)
                {
                    ListViewItem i = new ListViewItem(movie.title);
                    i.SubItems.Add(movie.release_date);
                    i.Tag = movie.id + ":" + "movie";
                    searchListView.Items.Add(i);
                }
            }
            if (tvCheckBox.Checked)
            {
                var s = SearchTV(searchTextBox.Text);

                foreach (TMDBSearchModels.TVResults show in s.results)
                {
                    ListViewItem i = new ListViewItem(show.name);
                    i.Tag = show.id + ":" + "show";
                    searchListView.Items.Add(i);
                }
            }
            if (gamesCheckBox.Checked)
            {
                var s = SearchGames(searchTextBox.Text);

                foreach (RAWGSearchModels.GameResults game in s.results)
                {
                    ListViewItem i = new ListViewItem(game.name);
                    i.SubItems.Add(game.released);
                    i.Tag = game.slug + ":" + "game";
                    searchListView.Items.Add(i);
                }
            }
        }

        private RAWGSearchModels.GameSearch SearchGames(string searchTerm)
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync("https://api.rawg.io/api/games?key=e7cb6ac232454c8c9b5211b61d6a1cc0&page=1&search=" + searchTerm);
            var results = JsonConvert.DeserializeObject<RAWGSearchModels.GameSearch>(json.Result);
            return results;
        }

        private TMDBSearchModels.TVSearch SearchTV(string searchTerm)
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync("https://api.themoviedb.org/3/search/tv?api_key=042a1784e44890d6d8b1484299f15b2c" + "&query=" + searchTerm);
            var results = JsonConvert.DeserializeObject<TMDBSearchModels.TVSearch>(json.Result);
            return results;
        }

        private TMDBSearchModels.MovieSearch SearchMovies(string searchTerm)
        {
            HttpClient client = new HttpClient();
            var json = client.GetStringAsync("https://api.themoviedb.org/3/search/movie?api_key=042a1784e44890d6d8b1484299f15b2c" + "&query=" + searchTerm);
            var results = JsonConvert.DeserializeObject<TMDBSearchModels.MovieSearch>(json.Result);
            return results;
        }

        private void addReminderButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in searchListView.SelectedItems)
            {
                var tag = i.Tag.ToString().Split(':');
                string name = i.Text;
                string release = i.SubItems[1].Text;

                mainForm.AddMedia(tag[0], name, release, tag[1]);
            }
            
            mainForm.Enabled = true;
            this.Close();
        }
    }
}
