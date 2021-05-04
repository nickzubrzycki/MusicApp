
namespace MusicApp
{
    partial class FormArtist
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
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.lblArtist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(25, 51);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(155, 20);
            this.txtArtist.TabIndex = 0;
            this.txtArtist.TextChanged += new System.EventHandler(this.txtArtist_TextChanged);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(65, 92);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(79, 23);
            this.btnAddArtist.TabIndex = 1;
            this.btnAddArtist.Text = "Toevoegen";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(22, 35);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(63, 13);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "Naam artist:";
            // 
            // FormArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 160);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.txtArtist);
            this.Name = "FormArtist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormArtist";
            this.Load += new System.EventHandler(this.FormArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Label lblArtist;
    }
}