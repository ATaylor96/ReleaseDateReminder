using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderUI.Controls
{
    public partial class MovieControl : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public MovieControl()
        {
            InitializeComponent();


            Rectangle r = new Rectangle(0, 0, 182, 268);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 10;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            pictureBox1.Region = new Region(gp);

            setViewStyleToolTip.SetToolTip(viewStyleBtn, "Grid View");
        }

        private void viewStyleBtn_Click(object sender, EventArgs e)
        {
            if (viewStyleBtn.Tag.ToString() == "grid")
            {
                viewStyleBtn.BackgroundImage = ReminderUI.Properties.Resources.outline_format_list_bulleted_white_24dp;
                setViewStyleToolTip.SetToolTip(viewStyleBtn, "Grid View");
                viewStyleBtn.Tag = "detail";
            }
            else
            {
                viewStyleBtn.BackgroundImage = ReminderUI.Properties.Resources.outline_apps_white_24dp;
                setViewStyleToolTip.SetToolTip(viewStyleBtn, "Detail View");
                viewStyleBtn.Tag = "grid";
            }
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(67, 69, 74);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(56, 58, 64);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(75, 77, 82);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(67, 69, 74);
        }
    }
}
