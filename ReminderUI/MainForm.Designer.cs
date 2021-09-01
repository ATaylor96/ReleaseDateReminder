
namespace ReminderUI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.myListBtn = new System.Windows.Forms.Button();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.gamesBtn = new System.Windows.Forms.Button();
            this.televisionBtn = new System.Windows.Forms.Button();
            this.moviesBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.moviesControl1 = new ReminderUI.Controls.MovieControl();
            this.navigationPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.navigationPanel.Controls.Add(this.settingsBtn);
            this.navigationPanel.Controls.Add(this.myListBtn);
            this.navigationPanel.Controls.Add(this.calendarBtn);
            this.navigationPanel.Controls.Add(this.gamesBtn);
            this.navigationPanel.Controls.Add(this.televisionBtn);
            this.navigationPanel.Controls.Add(this.moviesBtn);
            this.navigationPanel.Controls.Add(this.titleLabel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(3, 3);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(244, 743);
            this.navigationPanel.TabIndex = 0;
            this.navigationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigationPanel_MouseDown);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
            this.settingsBtn.Image = global::ReminderUI.Properties.Resources.outline_settings_black_24dp1;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(12, 309);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.settingsBtn.Size = new System.Drawing.Size(218, 40);
            this.settingsBtn.TabIndex = 19;
            this.settingsBtn.Text = "          Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // myListBtn
            // 
            this.myListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.myListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.myListBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.myListBtn.FlatAppearance.BorderSize = 0;
            this.myListBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.myListBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.myListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myListBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myListBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
            this.myListBtn.Image = global::ReminderUI.Properties.Resources.outline_format_list_bulleted_white_24dp;
            this.myListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myListBtn.Location = new System.Drawing.Point(12, 217);
            this.myListBtn.Name = "myListBtn";
            this.myListBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.myListBtn.Size = new System.Drawing.Size(218, 40);
            this.myListBtn.TabIndex = 18;
            this.myListBtn.Text = "          My List";
            this.myListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myListBtn.UseVisualStyleBackColor = false;
            this.myListBtn.Click += new System.EventHandler(this.myListBtn_Click);
            // 
            // calendarBtn
            // 
            this.calendarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.calendarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.calendarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.calendarBtn.FlatAppearance.BorderSize = 0;
            this.calendarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.calendarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.calendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
            this.calendarBtn.Image = global::ReminderUI.Properties.Resources.outline_today_black_24dp1;
            this.calendarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarBtn.Location = new System.Drawing.Point(12, 263);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.calendarBtn.Size = new System.Drawing.Size(218, 40);
            this.calendarBtn.TabIndex = 18;
            this.calendarBtn.Text = "          Calendar";
            this.calendarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarBtn.UseVisualStyleBackColor = false;
            this.calendarBtn.Click += new System.EventHandler(this.calendarBtn_Click);
            // 
            // gamesBtn
            // 
            this.gamesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.gamesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gamesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.gamesBtn.FlatAppearance.BorderSize = 0;
            this.gamesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.gamesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.gamesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
            this.gamesBtn.Image = global::ReminderUI.Properties.Resources.outline_games_black_24dp1;
            this.gamesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gamesBtn.Location = new System.Drawing.Point(12, 171);
            this.gamesBtn.Name = "gamesBtn";
            this.gamesBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.gamesBtn.Size = new System.Drawing.Size(218, 40);
            this.gamesBtn.TabIndex = 17;
            this.gamesBtn.Text = "          Games";
            this.gamesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gamesBtn.UseVisualStyleBackColor = false;
            this.gamesBtn.Click += new System.EventHandler(this.gamesBtn_Click);
            // 
            // televisionBtn
            // 
            this.televisionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.televisionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.televisionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.televisionBtn.FlatAppearance.BorderSize = 0;
            this.televisionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.televisionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.televisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.televisionBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.televisionBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(167)))), ((int)(((byte)(169)))));
            this.televisionBtn.Image = global::ReminderUI.Properties.Resources.outline_live_tv_black_24dp1;
            this.televisionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.televisionBtn.Location = new System.Drawing.Point(12, 125);
            this.televisionBtn.Name = "televisionBtn";
            this.televisionBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.televisionBtn.Size = new System.Drawing.Size(218, 40);
            this.televisionBtn.TabIndex = 16;
            this.televisionBtn.Text = "          Television";
            this.televisionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.televisionBtn.UseVisualStyleBackColor = false;
            this.televisionBtn.Click += new System.EventHandler(this.televisionBtn_Click);
            // 
            // moviesBtn
            // 
            this.moviesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.moviesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.moviesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(177)))), ((int)(((byte)(191)))));
            this.moviesBtn.FlatAppearance.BorderSize = 0;
            this.moviesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.moviesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.moviesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moviesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesBtn.ForeColor = System.Drawing.Color.White;
            this.moviesBtn.Image = global::ReminderUI.Properties.Resources.outline_movie_black_24dp3;
            this.moviesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moviesBtn.Location = new System.Drawing.Point(12, 79);
            this.moviesBtn.Name = "moviesBtn";
            this.moviesBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.moviesBtn.Size = new System.Drawing.Size(218, 40);
            this.moviesBtn.TabIndex = 4;
            this.moviesBtn.Text = "          Movies";
            this.moviesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moviesBtn.UseVisualStyleBackColor = false;
            this.moviesBtn.Click += new System.EventHandler(this.moviesBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.titleLabel.Location = new System.Drawing.Point(17, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(134, 37);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "Reminder";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.navigationPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, -3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1356, 749);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Location = new System.Drawing.Point(253, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1100, 743);
            this.mainPanel.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.Controls.Add(this.moviesControl1);
            this.contentPanel.Location = new System.Drawing.Point(0, 37);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1100, 706);
            this.contentPanel.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 34);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ReminderUI.Properties.Resources.outline_close_white_18dp;
            this.button1.Location = new System.Drawing.Point(1058, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.button1.Size = new System.Drawing.Size(42, 28);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::ReminderUI.Properties.Resources.outline_minimize_white_18dp;
            this.button3.Location = new System.Drawing.Point(976, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.button3.Size = new System.Drawing.Size(42, 28);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(154)))), ((int)(((byte)(248)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ReminderUI.Properties.Resources.outline_stop_white_24dp;
            this.button2.Location = new System.Drawing.Point(1017, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.button2.Size = new System.Drawing.Size(42, 28);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // moviesControl1
            // 
            this.moviesControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moviesControl1.BackColor = System.Drawing.Color.White;
            this.moviesControl1.Location = new System.Drawing.Point(0, 0);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(1100, 706);
            this.moviesControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1350, 743);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button calendarBtn;
        private System.Windows.Forms.Button gamesBtn;
        private System.Windows.Forms.Button televisionBtn;
        private System.Windows.Forms.Button moviesBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel contentPanel;
        private Controls.MovieControl moviesControl1;
        private System.Windows.Forms.Button myListBtn;
    }
}

