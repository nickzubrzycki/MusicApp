using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
        }

        private void btnAanmaken_Click(object sender, EventArgs e)
        {
            using (var ctx = new MusicAppContext())
            {
                ctx.Users.Add(new User()
                {
                    FirstName = txtVoornaam.Text,
                    LastName = txtAchternaam.Text,
                    Email = txtEmail.Text,
                    Password = txtPaswoord.Text
                });
                ctx.SaveChanges();
            }
            MessageBox.Show("Uw account werd met succes aangemaakt!");
            Close();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
