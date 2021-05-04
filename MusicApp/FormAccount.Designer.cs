
namespace MusicApp
{
    partial class FormAccount
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
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPaswoord = new System.Windows.Forms.TextBox();
            this.btnAanmaken = new System.Windows.Forms.Button();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPaswoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(346, 59);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(100, 20);
            this.txtVoornaam.TabIndex = 0;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(346, 120);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(100, 20);
            this.txtAchternaam.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(346, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPaswoord
            // 
            this.txtPaswoord.Location = new System.Drawing.Point(346, 258);
            this.txtPaswoord.Name = "txtPaswoord";
            this.txtPaswoord.Size = new System.Drawing.Size(100, 20);
            this.txtPaswoord.TabIndex = 3;
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.Location = new System.Drawing.Point(335, 309);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(121, 23);
            this.btnAanmaken.TabIndex = 4;
            this.btnAanmaken.Text = "Maak account aan";
            this.btnAanmaken.UseVisualStyleBackColor = true;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(343, 43);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(58, 13);
            this.lblVoornaam.TabIndex = 5;
            this.lblVoornaam.Text = "Voornaam:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(343, 104);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(67, 13);
            this.lblAchternaam.TabIndex = 6;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(343, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblPaswoord
            // 
            this.lblPaswoord.AutoSize = true;
            this.lblPaswoord.Location = new System.Drawing.Point(343, 242);
            this.lblPaswoord.Name = "lblPaswoord";
            this.lblPaswoord.Size = new System.Drawing.Size(57, 13);
            this.lblPaswoord.TabIndex = 8;
            this.lblPaswoord.Text = "Paswoord:";
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPaswoord);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.txtPaswoord);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Name = "FormAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPaswoord;
        private System.Windows.Forms.Button btnAanmaken;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPaswoord;
    }
}