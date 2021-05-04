
namespace MusicApp
{
    partial class FormSong
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
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lblSelectAlbum = new System.Windows.Forms.Label();
            this.cbAlbums = new System.Windows.Forms.ComboBox();
            this.lblSong = new System.Windows.Forms.Label();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.nudLengte = new System.Windows.Forms.NumericUpDown();
            this.lblLengte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLengte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(99, 204);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(92, 23);
            this.btnAddSong.TabIndex = 9;
            this.btnAddSong.Text = "Toevoegen";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lblSelectAlbum
            // 
            this.lblSelectAlbum.AutoSize = true;
            this.lblSelectAlbum.Location = new System.Drawing.Point(64, 136);
            this.lblSelectAlbum.Name = "lblSelectAlbum";
            this.lblSelectAlbum.Size = new System.Drawing.Size(86, 13);
            this.lblSelectAlbum.TabIndex = 8;
            this.lblSelectAlbum.Text = "Selecteer album:";
            // 
            // cbAlbums
            // 
            this.cbAlbums.FormattingEnabled = true;
            this.cbAlbums.Location = new System.Drawing.Point(67, 152);
            this.cbAlbums.Name = "cbAlbums";
            this.cbAlbums.Size = new System.Drawing.Size(149, 21);
            this.cbAlbums.TabIndex = 7;
            this.cbAlbums.SelectedIndexChanged += new System.EventHandler(this.cbAlbums_SelectedIndexChanged);
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(64, 30);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(56, 13);
            this.lblSong.TabIndex = 6;
            this.lblSong.Text = "Titel song:";
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(67, 46);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(149, 20);
            this.txtSong.TabIndex = 5;
            this.txtSong.TextChanged += new System.EventHandler(this.txtSong_TextChanged);
            // 
            // nudLengte
            // 
            this.nudLengte.Location = new System.Drawing.Point(67, 99);
            this.nudLengte.Name = "nudLengte";
            this.nudLengte.Size = new System.Drawing.Size(53, 20);
            this.nudLengte.TabIndex = 10;
            this.nudLengte.ValueChanged += new System.EventHandler(this.nudLengte_ValueChanged);
            // 
            // lblLengte
            // 
            this.lblLengte.AutoSize = true;
            this.lblLengte.Location = new System.Drawing.Point(64, 83);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(89, 13);
            this.lblLengte.TabIndex = 11;
            this.lblLengte.Text = "Lengte (minuten):";
            // 
            // FormSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 272);
            this.Controls.Add(this.lblLengte);
            this.Controls.Add(this.nudLengte);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.lblSelectAlbum);
            this.Controls.Add(this.cbAlbums);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.txtSong);
            this.Name = "FormSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSong";
            this.Load += new System.EventHandler(this.FormSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLengte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Label lblSelectAlbum;
        private System.Windows.Forms.ComboBox cbAlbums;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.NumericUpDown nudLengte;
        private System.Windows.Forms.Label lblLengte;
    }
}