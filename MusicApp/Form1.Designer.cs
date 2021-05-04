
namespace MusicApp
{
    partial class Form1
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
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.txtUserPW = new System.Windows.Forms.TextBox();
            this.lblUserMail = new System.Windows.Forms.Label();
            this.lblUserPW = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(403, 179);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(126, 23);
            this.btnNewAccount.TabIndex = 0;
            this.btnNewAccount.Text = "Account aanmaken";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(59, 242);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Inloggen";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(341, 38);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(87, 13);
            this.lblTitel.TabIndex = 2;
            this.lblTitel.Text = " MY MUSIC APP";
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(59, 153);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(126, 20);
            this.txtUserMail.TabIndex = 3;
            // 
            // txtUserPW
            // 
            this.txtUserPW.Location = new System.Drawing.Point(59, 195);
            this.txtUserPW.Name = "txtUserPW";
            this.txtUserPW.Size = new System.Drawing.Size(126, 20);
            this.txtUserPW.TabIndex = 4;
            // 
            // lblUserMail
            // 
            this.lblUserMail.AutoSize = true;
            this.lblUserMail.Location = new System.Drawing.Point(56, 137);
            this.lblUserMail.Name = "lblUserMail";
            this.lblUserMail.Size = new System.Drawing.Size(38, 13);
            this.lblUserMail.TabIndex = 5;
            this.lblUserMail.Text = "E-mail:";
            // 
            // lblUserPW
            // 
            this.lblUserPW.AutoSize = true;
            this.lblUserPW.Location = new System.Drawing.Point(56, 179);
            this.lblUserPW.Name = "lblUserPW";
            this.lblUserPW.Size = new System.Drawing.Size(57, 13);
            this.lblUserPW.TabIndex = 6;
            this.lblUserPW.Text = "Paswoord:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(400, 153);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(320, 13);
            this.lblAccount.TabIndex = 7;
            this.lblAccount.Text = "Nog geen account? Klik hieronder om een account aan te maken.";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(403, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Afsluiten";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblUserPW);
            this.Controls.Add(this.lblUserMail);
            this.Controls.Add(this.txtUserPW);
            this.Controls.Add(this.txtUserMail);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnNewAccount);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startmenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.TextBox txtUserPW;
        private System.Windows.Forms.Label lblUserMail;
        private System.Windows.Forms.Label lblUserPW;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnExit;
    }
}

