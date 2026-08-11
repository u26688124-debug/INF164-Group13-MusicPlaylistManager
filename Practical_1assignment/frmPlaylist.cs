using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_1assignment
{
    public partial class frmPlaylist : Form
    {
        // 1. Variable to hold the title passed from Home
        private string playlistTitle;
        public frmPlaylist(string title)
        {
            InitializeComponent();
            // Catching the title 
            playlistTitle = title;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            // Show the title passed from the Home form
            lblTitle.Text = "Playlist: " + playlistTitle;

            // Generate today's date directly from the system
            lblDate.Text = "Created: " + DateTime.Now.ToShortDateString();
        }

        private void pbCover_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Create a new dialog box to let the user browse their computer for a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Open the dialog and check if the user successfully selected a file and clicked "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Set the PictureBox image path to the exact file the user just selected
                    pbCover.ImageLocation = openFileDialog.FileName;
                    // Adjust the image size so it stretches to fit perfectly inside the PictureBox
                    pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    // If an error occurs (like selecting a corrupted file), show an error message instead of crashing
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}
