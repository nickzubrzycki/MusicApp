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
    public partial class FormAlbum : Form
    {
        public FormAlbum()
        {
            InitializeComponent();

            using (var ctx = new MusicAppContext())
            {
                List<Artist> artists = ctx.Artists.ToList();
                cbArtists.ValueMember = "ArtistId";
                cbArtists.DisplayMember = "Name";
                cbArtists.DataSource = artists;
            }
        }

        private void txtNameAlbum_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbArtists_SelectedIndexChanged(object sender, EventArgs e)
        {         
          
        }
        

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            Artist selected = cbArtists.SelectedItem as Artist;

            using (var ctx = new MusicAppContext())
            {
                Album album = new Album()                
                {                    
                    Name = txtNameAlbum.Text,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now                    
                };                
                ctx.Albums.Add(album);
                ctx.SaveChanges();
            }
            Close();
        }

        private void FormAlbum_Load(object sender, EventArgs e)
        {

        }
    }
}
