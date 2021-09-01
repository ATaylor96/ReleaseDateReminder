
namespace ReminderUI.Controls
{
    partial class MovieControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.moviePanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.viewStyleBtn = new System.Windows.Forms.Button();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.previousPageBtn = new System.Windows.Forms.Button();
            this.searchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.setViewStyleToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchPanel.SuspendLayout();
            this.moviePanel.SuspendLayout();
            this.searchFlowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchBtn);
            this.searchPanel.Location = new System.Drawing.Point(148, 13);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(510, 33);
            this.searchPanel.TabIndex = 16;
            // 
            // searchTextBox
            // 
            this.searchTextBox.AcceptsReturn = true;
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.searchTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(458, 31);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.searchBtn.BackgroundImage = global::ReminderUI.Properties.Resources.baseline_search_white_24dp;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(460, 0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.searchBtn.Size = new System.Drawing.Size(50, 33);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nobody";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.label3.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(17, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(105, 37);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Movies";
            // 
            // moviePanel
            // 
            this.moviePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moviePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.moviePanel.Controls.Add(this.label10);
            this.moviePanel.Controls.Add(this.viewStyleBtn);
            this.moviePanel.Controls.Add(this.nextPageBtn);
            this.moviePanel.Controls.Add(this.previousPageBtn);
            this.moviePanel.Controls.Add(this.searchFlowLayoutPanel);
            this.moviePanel.Controls.Add(this.titleLabel);
            this.moviePanel.Controls.Add(this.searchPanel);
            this.moviePanel.Location = new System.Drawing.Point(0, 0);
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.Size = new System.Drawing.Size(1100, 743);
            this.moviePanel.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
            this.label10.Location = new System.Drawing.Point(994, 700);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "1 / 10";
            // 
            // viewStyleBtn
            // 
            this.viewStyleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewStyleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.viewStyleBtn.BackgroundImage = global::ReminderUI.Properties.Resources.outline_apps_white_24dp;
            this.viewStyleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewStyleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewStyleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.viewStyleBtn.FlatAppearance.BorderSize = 0;
            this.viewStyleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.viewStyleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.viewStyleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewStyleBtn.Location = new System.Drawing.Point(1052, 20);
            this.viewStyleBtn.Name = "viewStyleBtn";
            this.viewStyleBtn.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.viewStyleBtn.Size = new System.Drawing.Size(24, 24);
            this.viewStyleBtn.TabIndex = 22;
            this.viewStyleBtn.Tag = "grid";
            this.viewStyleBtn.UseVisualStyleBackColor = false;
            this.viewStyleBtn.Click += new System.EventHandler(this.viewStyleBtn_Click);
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.nextPageBtn.BackgroundImage = global::ReminderUI.Properties.Resources.outline_navigate_next_white_18dp;
            this.nextPageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nextPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.nextPageBtn.FlatAppearance.BorderSize = 0;
            this.nextPageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.nextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPageBtn.Location = new System.Drawing.Point(1046, 702);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.nextPageBtn.Size = new System.Drawing.Size(30, 20);
            this.nextPageBtn.TabIndex = 22;
            this.nextPageBtn.UseVisualStyleBackColor = false;
            // 
            // previousPageBtn
            // 
            this.previousPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.previousPageBtn.BackgroundImage = global::ReminderUI.Properties.Resources.outline_navigate_before_white_18dp;
            this.previousPageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previousPageBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.previousPageBtn.FlatAppearance.BorderSize = 0;
            this.previousPageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.previousPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPageBtn.Location = new System.Drawing.Point(958, 702);
            this.previousPageBtn.Name = "previousPageBtn";
            this.previousPageBtn.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.previousPageBtn.Size = new System.Drawing.Size(30, 20);
            this.previousPageBtn.TabIndex = 4;
            this.previousPageBtn.UseVisualStyleBackColor = false;
            // 
            // searchFlowLayoutPanel
            // 
            this.searchFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFlowLayoutPanel.AutoScroll = true;
            this.searchFlowLayoutPanel.Controls.Add(this.panel2);
            this.searchFlowLayoutPanel.Controls.Add(this.panel1);
            this.searchFlowLayoutPanel.Controls.Add(this.panel3);
            this.searchFlowLayoutPanel.Location = new System.Drawing.Point(24, 64);
            this.searchFlowLayoutPanel.Name = "searchFlowLayoutPanel";
            this.searchFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.searchFlowLayoutPanel.Size = new System.Drawing.Size(1052, 623);
            this.searchFlowLayoutPanel.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 327);
            this.panel2.TabIndex = 22;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ReminderUI.Properties.Resources.MV5BMjM5YTRlZmUtZGVmYi00ZjE2LWIyNzAtOWVhMDk1MDdkYzhjXkEyXkFqcGdeQXVyMjMxOTE0ODA___V1_UX182_CR0_0_182_268_AL_;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 268);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(1, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "2021";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.label4.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(206, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 327);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ReminderUI.Properties.Resources.MV5BMjM5YTRlZmUtZGVmYi00ZjE2LWIyNzAtOWVhMDk1MDdkYzhjXkEyXkFqcGdeQXVyMjMxOTE0ODA___V1_UX182_CR0_0_182_268_AL_;
            this.pictureBox2.Location = new System.Drawing.Point(5, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 268);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(1, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "2021";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nobody";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(404, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 327);
            this.panel3.TabIndex = 24;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::ReminderUI.Properties.Resources.MV5BMjM5YTRlZmUtZGVmYi00ZjE2LWIyNzAtOWVhMDk1MDdkYzhjXkEyXkFqcGdeQXVyMjMxOTE0ODA___V1_UX182_CR0_0_182_268_AL_;
            this.pictureBox3.Location = new System.Drawing.Point(5, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 268);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(1, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "2021";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nobody";
            // 
            // MovieControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.moviePanel);
            this.Name = "MovieControl";
            this.Size = new System.Drawing.Size(1100, 743);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.moviePanel.ResumeLayout(false);
            this.moviePanel.PerformLayout();
            this.searchFlowLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel moviePanel;
        private System.Windows.Forms.FlowLayoutPanel searchFlowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button previousPageBtn;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button viewStyleBtn;
        private System.Windows.Forms.ToolTip setViewStyleToolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
