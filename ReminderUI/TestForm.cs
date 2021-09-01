using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderUI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void addReminderButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            TestSearchForm form = new TestSearchForm(this);
            form.Show();
        }

        public void AddMedia(string id, string name, string release, string mediaFormat)
        {
            ListViewItem i = new ListViewItem(name);
            i.SubItems.Add(release);
            i.Tag = id + ":" + mediaFormat;
            mediaListView.Items.Add(i);
        }
    }
}
