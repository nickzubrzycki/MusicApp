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
    public partial class FormSong : Form
    {
        public FormSong()
        {
            InitializeComponent();

            using (var ctx = new MusicAppContext())
            {
                List<Album> albums = ctx.Albums.ToList();
                cbAlbums.ValueMember = "AlbumId";
                cbAlbums.DisplayMember = "Name";
                cbAlbums.DataSource = albums;
            }
        }

        private void FormSong_Load(object sender, EventArgs e)
        {

        }

        private void cbAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            Album selected = cbAlbums.SelectedItem as Album;

            using (var ctx = new MusicAppContext())
            {
                Song song = new Song()                
                {
                    Title = txtSong.Text,                    
                    Length = (int)nudLengte.Value,                    
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now       
                    
                };
                ctx.Songs.Add(song);                
                ctx.SaveChanges();
            }
            Close();
        }

        private void txtSong_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudLengte_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
