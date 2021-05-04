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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            using (FormArtist formArtist = new FormArtist())
            {
                if (formArtist.ShowDialog() == DialogResult.OK)
                {
                    formArtist.Close();
                }
            }
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            using (FormAlbum formAlbum = new FormAlbum())
            {
                if (formAlbum.ShowDialog() == DialogResult.OK)
                {
                    formAlbum.Close();
                }
            }
        }

        private void btnSong_Click(object sender, EventArgs e)
        {
            using (FormSong formSong = new FormSong())
            {
                if (formSong.ShowDialog() == DialogResult.OK)
                {
                    formSong.Close();
                }
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            using (FormPlaylist formPlaylist = new FormPlaylist())
            {
                if (formPlaylist.ShowDialog() == DialogResult.OK)
                {
                    formPlaylist.Close();
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            using (FormPlay formPlay = new FormPlay())
            {
                if (formPlay.ShowDialog() == DialogResult.OK)
                {
                    formPlay.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
