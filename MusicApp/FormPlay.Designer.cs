
namespace MusicApp
{
    partial class FormPlay
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
            this.cbPlaylists = new System.Windows.Forms.ComboBox();
            this.lblPlaylists = new System.Windows.Forms.Label();
            this.lbPLSongs = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPlaylists
            // 
            this.cbPlaylists.FormattingEnabled = true;
            this.cbPlaylists.Location = new System.Drawing.Point(23, 40);
            this.cbPlaylists.Name = "cbPlaylists";
            this.cbPlaylists.Size = new System.Drawing.Size(171, 21);
            this.cbPlaylists.TabIndex = 0;
            this.cbPlaylists.SelectedIndexChanged += new System.EventHandler(this.cbPlaylists_SelectedIndexChanged);
            // 
            // lblPlaylists
            // 
            this.lblPlaylists.AutoSize = true;
            this.lblPlaylists.Location = new System.Drawing.Point(20, 24);
            this.lblPlaylists.Name = "lblPlaylists";
            this.lblPlaylists.Size = new System.Drawing.Size(110, 13);
            this.lblPlaylists.TabIndex = 1;
            this.lblPlaylists.Text = "Selecteer een playlist:";
            // 
            // lbPLSongs
            // 
            this.lbPLSongs.FormattingEnabled = true;
            this.lbPLSongs.Location = new System.Drawing.Point(23, 67);
            this.lbPLSongs.Name = "lbPLSongs";
            this.lbPLSongs.Size = new System.Drawing.Size(171, 173);
            this.lbPLSongs.TabIndex = 2;
            this.lbPLSongs.SelectedIndexChanged += new System.EventHandler(this.lbPLSongs_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Webdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPlay.Location = new System.Drawing.Point(246, 121);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 45);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(123, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Sluiten";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 352);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbPLSongs);
            this.Controls.Add(this.lblPlaylists);
            this.Controls.Add(this.cbPlaylists);
            this.Name = "FormPlay";
            this.Text = "FormPlay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlaylists;
        private System.Windows.Forms.Label lblPlaylists;
        private System.Windows.Forms.ListBox lbPLSongs;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
    }
}