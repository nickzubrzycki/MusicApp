using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            using (FormAccount formAccount = new FormAccount())
            {
                if (formAccount.ShowDialog() == DialogResult.OK)
                {
                    formAccount.Close();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {           
            string email = txtUserMail.Text;
            string paswoord = txtUserPW.Text;

            using (var ctx = new MusicAppContext())
            {
                bool exists = ctx.Users.Any(u => u.Email == email);

                if (exists)
                {
                    var user = ctx.Users.Select(u => u).Where(u => u.Email == email);

                    if (user.Any(u => u.Password == paswoord))
                    {
                        using (FormMain formMain = new FormMain())
                        {
                            if (formMain.ShowDialog() == DialogResult.OK)
                            {
                                formMain.Close();
                            }
                        }
                    }
                }

                    
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
