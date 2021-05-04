
namespace MusicApp
{
    partial class FormPlaylist
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
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.txtNamePL = new System.Windows.Forms.TextBox();
            this.lblNamePL = new System.Windows.Forms.Label();
            this.btnMakePL = new System.Windows.Forms.Button();
            this.cbAlbums = new System.Windows.Forms.ComboBox();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.lbSonglist = new System.Windows.Forms.ListBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.lblSonglist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.Location = new System.Drawing.Point(279, 75);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(166, 212);
            this.lbPlaylist.TabIndex = 0;
            this.lbPlaylist.SelectedIndexChanged += new System.EventHandler(this.lbPlaylist_SelectedIndexChanged);
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Location = new System.Drawing.Point(276, 59);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(42, 13);
            this.lblPlaylist.TabIndex = 1;
            this.lblPlaylist.Text = "Playlist:";
            // 
            // txtNamePL
            // 
            this.txtNamePL.Location = new System.Drawing.Point(463, 145);
            this.txtNamePL.Name = "txtNamePL";
            this.txtNamePL.Size = new System.Drawing.Size(166, 20);
            this.txtNamePL.TabIndex = 2;
            this.txtNamePL.TextChanged += new System.EventHandler(this.txtNamePL_TextChanged);
            // 
            // lblNamePL
            // 
            this.lblNamePL.AutoSize = true;
            this.lblNamePL.Location = new System.Drawing.Point(460, 129);
            this.lblNamePL.Name = "lblNamePL";
            this.lblNamePL.Size = new System.Drawing.Size(72, 13);
            this.lblNamePL.TabIndex = 3;
            this.lblNamePL.Text = "Naam playlist:";
            // 
            // btnMakePL
            // 
            this.btnMakePL.Location = new System.Drawing.Point(494, 185);
            this.btnMakePL.Name = "btnMakePL";
            this.btnMakePL.Size = new System.Drawing.Size(108, 23);
            this.btnMakePL.TabIndex = 4;
            this.btnMakePL.Text = "Playlist aanmaken";
            this.btnMakePL.UseVisualStyleBackColor = true;
            this.btnMakePL.Click += new System.EventHandler(this.btnMakePL_Click);
            // 
            // cbAlbums
            // 
            this.cbAlbums.FormattingEnabled = true;
            this.cbAlbums.Location = new System.Drawing.Point(15, 25);
            this.cbAlbums.Name = "cbAlbums";
            this.cbAlbums.Size = new System.Drawing.Size(158, 21);
            this.cbAlbums.TabIndex = 5;
            this.cbAlbums.SelectedIndexChanged += new System.EventHandler(this.cbAlbums_SelectedIndexChanged);
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Location = new System.Drawing.Point(12, 9);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(107, 13);
            this.lblAlbums.TabIndex = 6;
            this.lblAlbums.Text = "Selecteer een album:";
            // 
            // lbSonglist
            // 
            this.lbSonglist.FormattingEnabled = true;
            this.lbSonglist.Location = new System.Drawing.Point(15, 75);
            this.lbSonglist.Name = "lbSonglist";
            this.lbSonglist.Size = new System.Drawing.Size(166, 212);
            this.lbSonglist.TabIndex = 7;
            this.lbSonglist.SelectedIndexChanged += new System.EventHandler(this.lbSonglist_SelectedIndexChanged);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(209, 129);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(45, 23);
            this.btnAddSong.TabIndex = 8;
            this.btnAddSong.Text = "=>";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(209, 167);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(45, 23);
            this.btnRemoveSong.TabIndex = 9;
            this.btnRemoveSong.Text = "<=";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // lblSonglist
            // 
            this.lblSonglist.AutoSize = true;
            this.lblSonglist.Location = new System.Drawing.Point(12, 59);
            this.lblSonglist.Name = "lblSonglist";
            this.lblSonglist.Size = new System.Drawing.Size(44, 13);
            this.lblSonglist.TabIndex = 10;
            this.lblSonglist.Text = "Songlist";
            // 
            // FormPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 323);
            this.Controls.Add(this.lblSonglist);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.lbSonglist);
            this.Controls.Add(this.lblAlbums);
            this.Controls.Add(this.cbAlbums);
            this.Controls.Add(this.btnMakePL);
            this.Controls.Add(this.lblNamePL);
            this.Controls.Add(this.txtNamePL);
            this.Controls.Add(this.lblPlaylist);
            this.Controls.Add(this.lbPlaylist);
            this.Name = "FormPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPlaylist";
            this.Load += new System.EventHandler(this.FormPlaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.TextBox txtNamePL;
        private System.Windows.Forms.Label lblNamePL;
        private System.Windows.Forms.Button btnMakePL;
        private System.Windows.Forms.ComboBox cbAlbums;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.ListBox lbSonglist;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Label lblSonglist;
    }
}