using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReminderUI.Controls;

namespace ReminderUI
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void navigationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            (new Classes.DropShadow()).ApplyShadows(this);
        }

        private void moviesBtn_Click(object sender, EventArgs e)
        {
            moviesBtn.ForeColor = Color.White;
            moviesBtn.BackColor = Color.FromArgb(91, 154, 248);

            televisionBtn.ForeColor = gamesBtn.ForeColor = calendarBtn.ForeColor = settingsBtn.ForeColor = Color.FromArgb(166, 167, 169);
            televisionBtn.BackColor = gamesBtn.BackColor = calendarBtn.BackColor = settingsBtn.BackColor = Color.FromArgb(34, 37, 42);

            contentPanel.Controls.Clear();
            MoviesControl moviePanel = new MoviesControl();
            moviePanel.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(moviePanel);
        }

        private void televisionBtn_Click(object sender, EventArgs e)
        {
            televisionBtn.ForeColor = Color.White;
            televisionBtn.BackColor = Color.FromArgb(91, 154, 248);

            moviesBtn.ForeColor = gamesBtn.ForeColor = calendarBtn.ForeColor = settingsBtn.ForeColor = Color.FromArgb(166, 167, 169);
            moviesBtn.BackColor = gamesBtn.BackColor = calendarBtn.BackColor = settingsBtn.BackColor = Color.FromArgb(34, 37, 42);

            contentPanel.Controls.Clear();
        }

        private void gamesBtn_Click(object sender, EventArgs e)
        {
            gamesBtn.ForeColor = Color.White;
            gamesBtn.BackColor = Color.FromArgb(91, 154, 248);

            televisionBtn.ForeColor = moviesBtn.ForeColor = calendarBtn.ForeColor = settingsBtn.ForeColor = Color.FromArgb(166, 167, 169);
            televisionBtn.BackColor = moviesBtn.BackColor = calendarBtn.BackColor = settingsBtn.BackColor = Color.FromArgb(34, 37, 42);

            contentPanel.Controls.Clear();
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            calendarBtn.ForeColor = Color.White;
            calendarBtn.BackColor = Color.FromArgb(91, 154, 248);

            televisionBtn.ForeColor = gamesBtn.ForeColor = moviesBtn.ForeColor = settingsBtn.ForeColor = Color.FromArgb(166, 167, 169);
            televisionBtn.BackColor = gamesBtn.BackColor = moviesBtn.BackColor = settingsBtn.BackColor = Color.FromArgb(34, 37, 42);

            contentPanel.Controls.Clear();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            settingsBtn.ForeColor = Color.White;
            settingsBtn.BackColor = Color.FromArgb(91, 154, 248);

            televisionBtn.ForeColor = gamesBtn.ForeColor = calendarBtn.ForeColor = moviesBtn.ForeColor = Color.FromArgb(166, 167, 169);
            televisionBtn.BackColor = gamesBtn.BackColor = calendarBtn.BackColor = moviesBtn.BackColor = Color.FromArgb(34, 37, 42);

            contentPanel.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
