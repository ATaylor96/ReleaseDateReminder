using System;
using System.Windows.Forms;
using Reminder.Classes;
using static System.Windows.Forms.LinkLabel;

namespace Reminder
{
    public partial class MovieDetailsPanel : UserControl
    {
        MainForm main;
        Movie movie;

        public MovieDetailsPanel(MainForm f, Movie m)
        {
            InitializeComponent();
            movie = m;
            main = f;
            PopulateDetails();
        }

        private void PopulateDetails()
        {
            try { posterPictureBox.Load(movie.Poster); }
            catch { }
            titleLabel.Text = movie.Title + " (" + movie.Year + ")";
            ratingLabel.Text = movie.Rated;
            releasedLabel.Text = movie.Released.ToString("d");
            runtimeLabel.Text = movie.Runtime;
            genreLabel.Text = movie.Genre;
            directorLabel.Text = movie.Director;
            writerLabel.Text = movie.Writer;
            actorsLabel.Text = movie.Actors;
            plotLabel.Text = movie.Plot;
            languageLabel.Text = movie.Language;
            countryLabel.Text = movie.Country;
            awardsLabel.Text = movie.Awards;
            ratingsLabel.Text = movie.Ratings.ToString();
            metascoreLabel.Text = movie.Metascore;
            imdbRatingLabel.Text = movie.imdbRating.ToString();
            imdbVotesLabel.Text = movie.imdbVotes;
            imdbIDLabel.Text = movie.imdbID;
            typeLabel.Text = movie.Type;
            dvdLabel.Text = movie.DVD;
            boxOfficeLabel.Text = movie.BoxOffice;
            productionLabel.Text = movie.Production;
            websiteLabel.Text = movie.Website;
        }

        private void removeTabBtn_Click(object sender, EventArgs e)
        {
            RemoveTab();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTab();
        }

        private void RemoveTab()
        {
            Control[] tabs = main.Controls.Find("tabControl1", false);
            ((TabControl)tabs[0]).TabPages.Remove((TabPage)this.Tag);
        }
    }
}
