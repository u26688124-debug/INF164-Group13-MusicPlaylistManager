using System;
using System.Windows.Forms;

namespace Statistics_and_Testing
{
    public partial class frmStats : Form
    {
        // Store reference to the library form
        private frmLibrary libraryForm;

        public frmStats(frmLibrary library)
        {
            InitializeComponent();
            libraryForm = library;

            // Display statistics when form loads
            DisplayStatistics();
        }

        private void DisplayStatistics()
        {
            // Get data from the library form
            int totalTracks = libraryForm.GetTotalTracks();
            TimeSpan totalDuration = libraryForm.GetTotalDuration();

            // Update the labels
            lblWrappedNumber.Text = totalTracks.ToString();
            lblWrappedStatement.Text = "Total Tracks in Your Library";

            // Find and update the duration label
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label && ctrl.Name == "lblDurationDisplay")
                {
                    ctrl.Text = "Total Duration: " + totalDuration.ToString(@"hh\:mm\:ss");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libraryForm.Show();
            this.Close();
        }
    }
}