using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practical_1assignment
{
    public partial class frmHomePage : Form
    {
        private string username;
        public frmHomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = "Welcome Back, " + username + "!";
            LoadPlaylists();
            
            
        }
       
        private void LoadPlaylists()
        {

            try
            {
                lstPlaylists.Items.Clear();
                StreamReader reader = new StreamReader("Playlists.txt");
                while (!reader.EndOfStream)
                {
                    string PlaylistLine = reader.ReadLine();
                    string[] playlistData = PlaylistLine.Split(',');

                    if (playlistData[2] == username)
                    {
                        lstPlaylists.Items.Add(playlistData[1]);
                    }
                }
                reader.Close();
            }
            catch (Exception IO)
            {
                MessageBox.Show("Could not load playlists", "Error");
            }
        }

        private void btnOpenPlaylist_Click_1(object sender, EventArgs e)
        {
            if (lstPlaylists.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a playlist", "Error");
            }
            else
            {
                string selectedPlaylist = lstPlaylists.SelectedItem.ToString();
                // frmPlaylist playlistForm = new frmPlaylist();
                // playlistForm.Show();
                this.Hide();
            }
        }

        private void btnNewPlaylist_Click_1(object sender, EventArgs e)
        {
            if (txtPlaylistName.Text == "")
            {
                MessageBox.Show("Please enter your playlist name", "Error");
            }
            else
            {
                try
                {
                    string playlistID = "P" + (lstPlaylists.Items.Count + 1).ToString() + "000";
                    StreamWriter writer = new StreamWriter("Playlists.txt", true);
                    writer.WriteLine(playlistID + "," + txtPlaylistName.Text + "," + username);
                    writer.Close();
                    LoadPlaylists();
                    txtPlaylistName.Clear();
                }
                catch (Exception IO)
                {
                    MessageBox.Show("Could not save playlist", "Error");
                }
            }
        }

        private void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch (lstPlaylists.SelectedIndex)
            {
                case 0:
                    pbCoverArt.Image = Image.FromFile("Images\\Cover1.png");
                    break;
                case 1:
                    pbCoverArt.Image = Image.FromFile("Images\\Cover2.png");
                    break;
                case 2:
                    pbCoverArt.Image = Image.FromFile("Images\\Cover3.png");
                    break;
                case 3:
                    pbCoverArt.Image = Image.FromFile("Images\\Cover4.png");
                    break;
                case 4:
                    pbCoverArt.Image = Image.FromFile("Images\\Cover5.png");
                    break; 
                case 5:
                    pbCoverArt.Image = Image.FromFile("Images\\Cover6.png");
                    break;
                case 6:
                    pbCoverArt.Image = Image.FromFile("Images\\Cover7.png");
                    break;
                default:
                    pbCoverArt.Image = Image.FromFile("Images\\Cover1.png");
                    break;
            }
        }

        
    }
}
