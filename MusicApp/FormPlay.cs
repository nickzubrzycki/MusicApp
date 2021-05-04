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
    public partial class FormPlay : Form
    {
        public FormPlay()
        {
            InitializeComponent();

            using (var ctx = new MusicAppContext())
            {
                List<Playlist> playlists = ctx.Playlists.ToList();
                cbPlaylists.ValueMember = "PlaylistId";
                cbPlaylists.DisplayMember = "Name";
                cbPlaylists.DataSource = playlists;
            }
        }

        private void cbPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            Playlist selected = cbPlaylists.SelectedItem as Playlist;

            using (var ctx = new MusicAppContext())
            {
                List<Song> playlist = selected.Songs.ToList();
                lbPLSongs.ValueMember = "SongId";
                lbPLSongs.DisplayMember = "Title";
                lbPLSongs.DataSource = playlist;
            }
        }

        private void lbPLSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
