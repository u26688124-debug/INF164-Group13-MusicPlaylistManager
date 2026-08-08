using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics_and_Testing
{
    public partial class frmLibrary : Form
    {

        // These lists will store playlist data
        private List<string> songNames = new List<string>();
        private List<string> artists = new List<string>();
        private List<TimeSpan> durations = new List<TimeSpan>();

        public frmLibrary()
        {
            InitializeComponent();
        }

        private void myWrappedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStats statsForm = new frmStats(this);
            statsForm.Show();
            this.Hide();
        }

        private void UpdateStatistics()
        {
            // STATISTIC 1: Total number of tracks
            int totalTracks = songNames.Count;
            lblTotalSongs.Text = "Total Songs: " + totalTracks.ToString();

            // STATISTIC 2: Total duration
            TimeSpan totalDuration = TimeSpan.Zero;
            foreach (TimeSpan duration in durations)
            {
                totalDuration = totalDuration + duration;
            }

            // Format as Hours:Minutes:Seconds
            lblDuration.Text = "Total Duration: " + totalDuration.ToString(@"hh\:mm\:ss");

            // STATISTIC 3: Most common artist
            if (artists.Count > 0)
            {
                var artistCounts = new Dictionary<string, int>();
                foreach (string artist in artists)
                {
                    if (artistCounts.ContainsKey(artist))
                        artistCounts[artist]++;
                    else
                        artistCounts[artist] = 1;
                }

                string mostCommon = "N/A";
                int maxCount = 0;
                foreach (var kvp in artistCounts)
                {
                    if (kvp.Value > maxCount)
                    {
                        maxCount = kvp.Value;
                        mostCommon = kvp.Key;
                    }
                }
            }
        }

        //Store data to pass it to frmStats
        public List<string> GetSongNames()
        {
            return songNames;
        }

        public List<TimeSpan> GetDurations()
        {
            return durations;
        }

        public int GetTotalTracks()
        {
            return songNames.Count;
        }

        public TimeSpan GetTotalDuration()
        {
            TimeSpan total = TimeSpan.Zero;
            foreach (TimeSpan duration in durations)
            {
                total = total + duration;
            }
            return total;
        }
    }
}



