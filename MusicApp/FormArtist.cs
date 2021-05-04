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
    public partial class FormArtist : Form
    {
        public FormArtist()
        {
            InitializeComponent();
        }

        private void txtArtist_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            using (var ctx = new MusicAppContext())
            {
                ctx.Artists.Add(new Artist()
                {
                    Name = txtArtist.Text,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
                ctx.SaveChanges();
            }
            Close();
        }

        private void FormArtist_Load(object sender, EventArgs e)
        {

        }
    }
}
