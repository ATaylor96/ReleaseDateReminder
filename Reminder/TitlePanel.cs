using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reminder.Classes;

namespace Reminder
{
    public partial class TitlePanel : UserControl
    {
        SearchResult searchResult;
        MainForm main;

        public TitlePanel(SearchResult result, MainForm mainForm)
        {
            InitializeComponent();
            main = mainForm;
            searchResult = result;
            pictureBox1.Load(result.Poster);
            label1.Text = result.Title;
            label2.Text = result.Year;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            main.LoadDetails(searchResult);
        }
    }
}
