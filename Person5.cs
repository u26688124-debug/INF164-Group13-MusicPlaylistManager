using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Form1 : Form
    {
        private string songsFilePath = "Songs.txt";
        string selectedSong = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void btnUploadSong_Click(object sender, EventArgs e)
        //Browse for a song
        {
            try
            {
                if (ofdMediaFile.ShowDialog() == DialogResult.OK)
                {
                    selectedSong = ofdMediaFile.FileName;

                    //Add and select the song in the ListBox
                    int index = lstSongs.Items.Add(selectedSong);
                    lstSongs.SelectedIndex = index;

                    UpdateTrackCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading songs: " + ex.Message);

            }
        }

        public void btnPlay_Click(object sender, EventArgs e)
        {
            //Play selected song
            try
            {
                if (lstSongs.SelectedItem != null)
                {
                    string songs = lstSongs.SelectedItem.ToString();
                    mediaPlayer.URL = songs;
                    mediaPlayer.Ctlcontrols.play();
                }
                else
                {
                    MessageBox.Show("Please select a song first");
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error playing song:" + ex.Message);
            }

        }

        public void btnStop_Click(object sender, EventArgs e)
        {
            //Stop song
            try
            {
                mediaPlayer.Ctlcontrols.stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping songs: " + ex.Message);
            }
        }

        // Update track count

        public void UpdateTrackCount()
        {
            lblTrackCount.Text = "Track Count: " + lstSongs.Items.Count;
        }

        // Get track count

        public int GetTrackCount()
        {
            return lstSongs.Items.Count;
        }
    }
}