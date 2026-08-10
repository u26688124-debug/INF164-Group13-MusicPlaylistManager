using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Statistics_and_Testing
{
    public partial class frmLibrary : Form
    {
        // Private data stores ensure only this form can modify the user's library directly.
        private List<string> songNames = new List<string>();
        private List<string> artists = new List<string>();
        private List<TimeSpan> durations = new List<TimeSpan>();
        private List<DateTime> datesAdded = new List<DateTime>();

        public frmLibrary()
        {
            InitializeComponent();
        }

        // Navigation passes a reference of this form to frmStats so it can read the library data.
        private void myWrappedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStats statsForm = new frmStats(this);
            statsForm.Show();
            this.Hide();
        }

        // Public getters safely expose read-only access to the private lists for other forms.
        public List<string> GetSongNames() { return songNames; }
        public List<string> GetArtists() { return artists; }
        public List<TimeSpan> GetDurations() { return durations; }
        public List<DateTime> GetDatesAdded() { return datesAdded; }

        // Call this method inside "Add Song" UI button to  record new user input.
        public void AddSongToLibrary(string songName, string artist, TimeSpan duration)
        {
            songNames.Add(songName);
            artists.Add(artist);
            durations.Add(duration);
            datesAdded.Add(DateTime.Now);
        }
    }
}