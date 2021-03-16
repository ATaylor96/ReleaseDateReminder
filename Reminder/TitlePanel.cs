using System;
using System.Drawing;
using System.Windows.Forms;
using Reminder.Classes;

namespace Reminder
{
    public partial class TitlePanel : UserControl
    {
        SearchResult searchResult;
        MainForm main;

        public TitlePanel(MainForm mainForm, SearchResult result)
        {
            InitializeComponent();
            main = mainForm;
            searchResult = result;
            try
            {
                pictureBox1.Load(result.Poster);
            }
            catch { };
            label1.Text = result.Title;
            label2.Text = result.Year;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            main.LoadDetails(searchResult);
        }

        private void TitlePanel_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void TitlePanel_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }
    }
}
