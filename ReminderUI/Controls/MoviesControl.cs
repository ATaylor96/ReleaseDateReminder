using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderUI.Controls
{
    public partial class MoviesControl : UserControl
    {
        public MoviesControl()
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
            pictureBox2.Region = new Region(gp);
            pictureBox3.Region = new Region(gp);
            pictureBox4.Region = new Region(gp);
        }
    }
}
