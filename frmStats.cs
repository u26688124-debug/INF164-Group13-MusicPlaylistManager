using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Statistics_and_Testing
{
    public partial class frmStats : Form
    {
        private frmLibrary libraryForm;
        private List<TrackData> trackData;
        private string currentView = "Top Artists"; // Default view

        public frmStats(frmLibrary library)
        {
            InitializeComponent();
            libraryForm = library;

            // Load track data from library
            LoadTrackData();

            // Set default radio button
            radTotal.Checked = true;

            // Hook up events
            radTotal.CheckedChanged += RadioButton_CheckedChanged;
            radYear.CheckedChanged += RadioButton_CheckedChanged;
            radMonth.CheckedChanged += RadioButton_CheckedChanged;
            radWeek.CheckedChanged += RadioButton_CheckedChanged;

            btnArtist.Click += BtnArtist_Click;
            btnSong.Click += BtnSong_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;

            // Set default button style
            btnArtist.BackColor = System.Drawing.Color.LightBlue;

            // Initial display
            UpdateStatistics();
        }

        private void LoadTrackData()
        {
            // Retrieve all 4 lists from the library
            var songNames = libraryForm.GetSongNames();
            var artists = libraryForm.GetArtists();
            var durations = libraryForm.GetDurations();
            var datesAdded = libraryForm.GetDatesAdded();

            trackData = new List<TrackData>();

            // Prevents errors if user opens stats before adding any songs.
            if (songNames.Count == 0) return;

            for (int i = 0; i < songNames.Count; i++)
            {
                trackData.Add(new TrackData
                {
                    SongName = songNames[i],
                    Artist = artists[i],
                    Duration = durations[i],
                    DatePlayed = datesAdded[i], // Uses the actual date the user added the song
                    Genre = "Unknown", // Placeholder until you add genre input to your app
                    PlayCount = 0 // Real play count goes here when you implement history
                });
            }
        }

        
        // RADIO BUTTONS - Filter by Period
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                UpdateStatistics();
            }
        }

        
        // BUTTONS - Change View
        private void BtnArtist_Click(object sender, EventArgs e)
        {
            currentView = "Top Artists";
            btnArtist.BackColor = System.Drawing.Color.LightBlue;
            btnSong.BackColor = System.Drawing.SystemColors.Control;
            UpdateStatistics();
        }

        private void BtnSong_Click(object sender, EventArgs e)
        {
            currentView = "Top Tracks";
            btnSong.BackColor = System.Drawing.Color.LightBlue;
            btnArtist.BackColor = System.Drawing.SystemColors.Control;
            UpdateStatistics();
        }

        
        // MAIN UPDATE METHOD
        private void UpdateStatistics()
        {
            try
            {
                if (trackData == null || trackData.Count == 0)
                {
                    lblWrappedNumber.Text = "0";
                    lblWrappedStatement.Text = "No listening data available";
                    lblDurationDisplay.Text = "Duration: 00:00:00";
                    dataGridView1.Rows.Clear();
                    return;
                }

                // Step 1: Filter by selected period
                var filteredData = FilterByPeriod(trackData);

                if (filteredData.Count == 0)
                {
                    lblWrappedNumber.Text = "0";
                    lblWrappedStatement.Text = "No data for this period";
                    lblDurationDisplay.Text = "Duration: 00:00:00";
                    dataGridView1.Rows.Clear();
                    return;
                }

                // Step 2: Calculate total listening time
                double totalHours = filteredData.Sum(t => t.Duration.TotalHours);
                double totalMinutes = filteredData.Sum(t => t.Duration.TotalMinutes);

                // Step 3: Update the summary labels
                if (totalHours >= 1)
                {
                    lblWrappedNumber.Text = totalHours.ToString("F1");
                    lblWrappedStatement.Text = "Hours of Music Played";
                }
                else
                {
                    lblWrappedNumber.Text = totalMinutes.ToString("F0");
                    lblWrappedStatement.Text = "Minutes of Music Played";
                }

                TimeSpan totalDuration = TimeSpan.FromHours(totalHours);
                lblDurationDisplay.Text = "Total Duration: " + totalDuration.ToString(@"hh\:mm\:ss");

                // Step 4: Display the data based on current view
                if (currentView == "Top Artists")
                {
                    DisplayTopArtists(filteredData);
                }
                else // Top Tracks
                {
                    DisplayTopTracks(filteredData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating statistics: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        // FILTER BY PERIOD
        private List<TrackData> FilterByPeriod(List<TrackData> data)
        {
            if (radTotal.Checked)
                return data;

            DateTime now = DateTime.Now;
            DateTime filterDate = now;

            if (radWeek.Checked)
                filterDate = now.AddDays(-7);
            else if (radMonth.Checked)
                filterDate = now.AddMonths(-1);
            else if (radYear.Checked)
                filterDate = now.AddYears(-1);

            return data.Where(t => t.DatePlayed >= filterDate).ToList();
        }

        
        // DISPLAY METHODS
        private void DisplayTopArtists(List<TrackData> data)
        {
            dataGridView1.Rows.Clear();

            // Group by artist and calculate total listening time
            var artistGroups = data
                .GroupBy(t => t.Artist)
                .Select(g => new
                {
                    Artist = g.Key,
                    TotalHours = g.Sum(t => t.Duration.TotalHours),
                    TrackCount = g.Count(),
                    // Get the most common genre for this artist
                    Genre = g.GroupBy(t => t.Genre)
                            .OrderByDescending(gg => gg.Count())
                            .FirstOrDefault()?.Key ?? "Unknown",
                    // Calculate average play count per track for this artist
                    AvgPlays = g.Average(t => t.PlayCount)
                })
                .OrderByDescending(g => g.TotalHours) // Most listened first
                .ToList();

            int rank = 1;
            foreach (var artist in artistGroups)
            {
                dataGridView1.Rows.Add(
                    rank++,
                    artist.Artist,
                    "Click to add image",
                    artist.Genre,
                    artist.TotalHours.ToString("F1"),
                    artist.TrackCount,
                    artist.AvgPlays.ToString("F0")
                );
            }
        }

        private void DisplayTopTracks(List<TrackData> data)
        {
            dataGridView1.Rows.Clear();

            // Group by song and artist
            var trackGroups = data
                .GroupBy(t => new { t.SongName, t.Artist })
                .Select(g => new
                {
                    SongName = g.Key.SongName,
                    Artist = g.Key.Artist,
                    TotalHours = g.Sum(t => t.Duration.TotalHours),
                    PlayCount = g.Sum(t => t.PlayCount),
                    Genre = g.First().Genre
                })
                .OrderByDescending(g => g.TotalHours) // Most listened first
                .ToList();

            int rank = 1;
            foreach (var track in trackGroups)
            {
                dataGridView1.Rows.Add(
                    rank++,
                    track.SongName,
                    track.Artist,
                    "Click to add image",
                    track.Genre,
                    track.TotalHours.ToString("F1"),
                    track.PlayCount
                );
            }
        }

       
        // ADD IMAGE TO DATA GRID VIEW
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if clicked on Image column (colImage index = 2)
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select Artist/Track Image";
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    ofd.Multiselect = false;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            System.Drawing.Image img = System.Drawing.Image.FromFile(ofd.FileName);
                            System.Drawing.Image thumb = img.GetThumbnailImage(50, 50, null, IntPtr.Zero);

                            dataGridView1.Rows[e.RowIndex].Cells["colImage"].Value = thumb;

                            img.Dispose();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}",
                                          "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

       
        // EXIT BUTTON
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libraryForm.Show();
            this.Close();
        }

        
        // HELPER CLASS
        public class TrackData
        {
            public string SongName { get; set; }
            public string Artist { get; set; }
            public string Genre { get; set; }
            public TimeSpan Duration { get; set; }
            public DateTime DatePlayed { get; set; }
            public int PlayCount { get; set; }
        }
    }
}