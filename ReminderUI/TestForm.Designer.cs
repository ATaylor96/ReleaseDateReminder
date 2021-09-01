
namespace ReminderUI
{
    partial class TestForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.moviesCheckBox = new System.Windows.Forms.CheckBox();
            this.tvCheckBox = new System.Windows.Forms.CheckBox();
            this.gamesCheckBox = new System.Windows.Forms.CheckBox();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.previousPageButton = new System.Windows.Forms.Button();
            this.deleteReminderButton = new System.Windows.Forms.Button();
            this.addReminderButton = new System.Windows.Forms.Button();
            this.mediaListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(268, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // moviesCheckBox
            // 
            this.moviesCheckBox.AutoSize = true;
            this.moviesCheckBox.Checked = true;
            this.moviesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moviesCheckBox.Location = new System.Drawing.Point(12, 38);
            this.moviesCheckBox.Name = "moviesCheckBox";
            this.moviesCheckBox.Size = new System.Drawing.Size(60, 17);
            this.moviesCheckBox.TabIndex = 2;
            this.moviesCheckBox.Text = "Movies";
            this.moviesCheckBox.UseVisualStyleBackColor = true;
            // 
            // tvCheckBox
            // 
            this.tvCheckBox.AutoSize = true;
            this.tvCheckBox.Location = new System.Drawing.Point(78, 38);
            this.tvCheckBox.Name = "tvCheckBox";
            this.tvCheckBox.Size = new System.Drawing.Size(74, 17);
            this.tvCheckBox.TabIndex = 2;
            this.tvCheckBox.Text = "Television";
            this.tvCheckBox.UseVisualStyleBackColor = true;
            // 
            // gamesCheckBox
            // 
            this.gamesCheckBox.AutoSize = true;
            this.gamesCheckBox.Location = new System.Drawing.Point(158, 38);
            this.gamesCheckBox.Name = "gamesCheckBox";
            this.gamesCheckBox.Size = new System.Drawing.Size(59, 17);
            this.gamesCheckBox.TabIndex = 2;
            this.gamesCheckBox.Text = "Games";
            this.gamesCheckBox.UseVisualStyleBackColor = true;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(283, 34);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(60, 23);
            this.nextPageButton.TabIndex = 0;
            this.nextPageButton.Text = "Next";
            this.nextPageButton.UseVisualStyleBackColor = true;
            // 
            // previousPageButton
            // 
            this.previousPageButton.Location = new System.Drawing.Point(223, 34);
            this.previousPageButton.Name = "previousPageButton";
            this.previousPageButton.Size = new System.Drawing.Size(60, 23);
            this.previousPageButton.TabIndex = 0;
            this.previousPageButton.Text = "Previous";
            this.previousPageButton.UseVisualStyleBackColor = true;
            // 
            // deleteReminderButton
            // 
            this.deleteReminderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteReminderButton.Location = new System.Drawing.Point(183, 512);
            this.deleteReminderButton.Name = "deleteReminderButton";
            this.deleteReminderButton.Size = new System.Drawing.Size(160, 57);
            this.deleteReminderButton.TabIndex = 6;
            this.deleteReminderButton.Text = "Delete";
            this.deleteReminderButton.UseVisualStyleBackColor = true;
            // 
            // addReminderButton
            // 
            this.addReminderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReminderButton.Location = new System.Drawing.Point(12, 513);
            this.addReminderButton.Name = "addReminderButton";
            this.addReminderButton.Size = new System.Drawing.Size(160, 57);
            this.addReminderButton.TabIndex = 7;
            this.addReminderButton.Text = "Add";
            this.addReminderButton.UseVisualStyleBackColor = true;
            this.addReminderButton.Click += new System.EventHandler(this.addReminderButton_Click);
            // 
            // mediaListView
            // 
            this.mediaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mediaListView.FullRowSelect = true;
            this.mediaListView.HideSelection = false;
            this.mediaListView.Location = new System.Drawing.Point(12, 63);
            this.mediaListView.Name = "mediaListView";
            this.mediaListView.Size = new System.Drawing.Size(331, 443);
            this.mediaListView.TabIndex = 14;
            this.mediaListView.UseCompatibleStateImageBehavior = false;
            this.mediaListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 209;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Release Date";
            this.columnHeader2.Width = 114;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 582);
            this.Controls.Add(this.mediaListView);
            this.Controls.Add(this.deleteReminderButton);
            this.Controls.Add(this.addReminderButton);
            this.Controls.Add(this.gamesCheckBox);
            this.Controls.Add(this.tvCheckBox);
            this.Controls.Add(this.moviesCheckBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.previousPageButton);
            this.Controls.Add(this.nextPageButton);
            this.Controls.Add(this.searchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder - Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.CheckBox moviesCheckBox;
        private System.Windows.Forms.CheckBox tvCheckBox;
        private System.Windows.Forms.CheckBox gamesCheckBox;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button previousPageButton;
        private System.Windows.Forms.Button deleteReminderButton;
        private System.Windows.Forms.Button addReminderButton;
        private System.Windows.Forms.ListView mediaListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}