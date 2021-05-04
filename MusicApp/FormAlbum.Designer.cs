
namespace MusicApp
{
    partial class FormAlbum
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
            this.txtNameAlbum = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.cbArtists = new System.Windows.Forms.ComboBox();
            this.lblSelectArtist = new System.Windows.Forms.Label();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNameAlbum
            // 
            this.txtNameAlbum.Location = new System.Drawing.Point(49, 51);
            this.txtNameAlbum.Name = "txtNameAlbum";
            this.txtNameAlbum.Size = new System.Drawing.Size(149, 20);
            this.txtNameAlbum.TabIndex = 0;
            this.txtNameAlbum.TextChanged += new System.EventHandler(this.txtNameAlbum_TextChanged);
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(46, 35);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(69, 13);
            this.lblAlbum.TabIndex = 1;
            this.lblAlbum.Text = "Naam album:";
            // 
            // cbArtists
            // 
            this.cbArtists.FormattingEnabled = true;
            this.cbArtists.Location = new System.Drawing.Point(49, 108);
            this.cbArtists.Name = "cbArtists";
            this.cbArtists.Size = new System.Drawing.Size(149, 21);
            this.cbArtists.TabIndex = 2;
            this.cbArtists.SelectedIndexChanged += new System.EventHandler(this.cbArtists_SelectedIndexChanged);
            // 
            // lblSelectArtist
            // 
            this.lblSelectArtist.AutoSize = true;
            this.lblSelectArtist.Location = new System.Drawing.Point(46, 92);
            this.lblSelectArtist.Name = "lblSelectArtist";
            this.lblSelectArtist.Size = new System.Drawing.Size(80, 13);
            this.lblSelectArtist.TabIndex = 3;
            this.lblSelectArtist.Text = "Selecteer artist:";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(81, 160);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(92, 23);
            this.btnAddAlbum.TabIndex = 4;
            this.btnAddAlbum.Text = "Toevoegen";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 230);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.lblSelectArtist);
            this.Controls.Add(this.cbArtists);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.txtNameAlbum);
            this.Name = "FormAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAlbum";
            this.Load += new System.EventHandler(this.FormAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.ComboBox cbArtists;
        private System.Windows.Forms.Label lblSelectArtist;
        private System.Windows.Forms.Button btnAddAlbum;
    }
}