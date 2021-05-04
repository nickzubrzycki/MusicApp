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
    public partial class FormPlaylist : Form
    {        
        public FormPlaylist()
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

        private void cbAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album selected = cbAlbums.SelectedItem as Album;

            using (var ctx = new MusicAppContext())
            {
                List<Song> songlist = selected.Songs.ToList();
                lbSonglist.ValueMember = "SongId";
                lbSonglist.DisplayMember = "Title";
                lbSonglist.DataSource = songlist;

                foreach (Song item in songlist)
                {
                    lbSonglist.Items.Add(item.ToString());
                }
            }
        }

        private void lbSonglist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            Song selected = lbSonglist.SelectedItem as Song;
            lbPlaylist.Items.Add(selected);            
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            Song selected = lbPlaylist.SelectedItem as Song;
            lbPlaylist.Items.Remove(selected);
        }

        private void txtNamePL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMakePL_Click(object sender, EventArgs e)
        {
            using (var ctx = new MusicAppContext())
            {
                Playlist playlist = new Playlist()            
                {                    
                    
                    Name = txtNamePL.Text,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    
                };
                ctx.Playlists.Add(playlist);

                foreach (Song item in lbPlaylist.Items)
                {
                    playlist.Songs.Add(item);
                }
                ctx.SaveChanges();
            }
            
            Close();
        }

        private void FormPlaylist_Load(object sender, EventArgs e)
        {

        }
    }
}
