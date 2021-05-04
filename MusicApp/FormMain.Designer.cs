
namespace MusicApp
{
    partial class FormMain
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
            this.lblWelkom = new System.Windows.Forms.Label();
            this.btnArtist = new System.Windows.Forms.Button();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnSong = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.Location = new System.Drawing.Point(305, 36);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(140, 13);
            this.lblWelkom.TabIndex = 0;
            this.lblWelkom.Text = "Welkom in MY MUSIC APP!";
            // 
            // btnArtist
            // 
            this.btnArtist.Location = new System.Drawing.Point(216, 106);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(80, 54);
            this.btnArtist.TabIndex = 1;
            this.btnArtist.Text = "Artist toevoegen";
            this.btnArtist.UseVisualStyleBackColor = true;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.Location = new System.Drawing.Point(365, 106);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(80, 54);
            this.btnAlbum.TabIndex = 2;
            this.btnAlbum.Text = "Album toevoegen";
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnSong
            // 
            this.btnSong.Location = new System.Drawing.Point(515, 106);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(80, 54);
            this.btnSong.TabIndex = 3;
            this.btnSong.Text = "Song toevoegen";
            this.btnSong.UseVisualStyleBackColor = true;
            this.btnSong.Click += new System.EventHandler(this.btnSong_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Location = new System.Drawing.Point(216, 195);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(80, 54);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.Text = "Playlist aanmaken";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(365, 195);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 54);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Playlist afspelen";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(515, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 54);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Uitloggen";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.btnSong);
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.btnArtist);
            this.Controls.Add(this.lblWelkom);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnSong;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
    }
}