using System;
using System.IO; // Required for StreamReader and StreamWriter
using System.Windows.Forms;

namespace Person6
{
    public class FileHandler
    {
        //I NEED TO CHANGE THE FILE PATHS BELOW TO MATCH WHAT THE PERSON RESPONSIBLE FOR RETRIEVING THE FILES PROVIDES
        //NB: FOR THIS CODE TO WORK, THE PERSON RESPONSIBLE FOR RETRIEVING THE FILES MUST PROVIDE THE CORRECT FILE PATHS FOR USERS.TXT, PLAYLISTS.TXT, AND SONGS.TXT.
        // File paths pointing to your text files
        //CHANGE THE FILE PATHS BELOW TO MATCH WHAT THE PERSON RESPONSIBLE FOR RETRIEVING THE FILES PROVIDES
        string usersPath = @"C:\Users\Happymore Motsi\Downloads\Users.txt";//this will come from the person responsible for retrieving the users file
        string playlistsPath = @"C:\Users\Happymore Motsi\Downloads\Playlists.txt"; //this will come from the person responsible for retrieving the playlists file
        string songsPath = @"C:\Users\Happymore Motsi\Downloads\Songs.txt"; //this will come from the person responsible for retrieving the songs file


        // 1. USERS FILE MANAGEMENT (Users.txt)
        // bool method to check if user credentials match (For Person 1 Login & Person 2 Register)
        //This will be used by the person responsible for login and registration to verify if the provided username and password match any entry in the Users.txt file. It reads the file line by line, splits each line into username and password, and compares them with the provided credentials. If a match is found, it returns true; otherwise, it returns false.
        // the person responsible for login and registration should call this method when a user attempts to log in or register, passing the entered username and password as parameters. The method will return true if the credentials are valid and false if they are not.
        public bool CheckUsers(string Username, string Password)
        {
            StreamReader reader = null; // Step 1: Declare StreamReader
            bool isFound = false;

            try // Try block
            {
                if (File.Exists(usersPath))// Check if file exists
                {
                    reader = new StreamReader(usersPath); // Open users file
                    string line = reader.ReadLine(); // Read line

                    while (line != null) // Read until end of file
                    {
                        if (line.Trim() != "") //Skip empty lines
                        {
                            string[] fields = line.Split(','); //username and password are separated by a comma

                            // Ensure array bounds exist to prevent crash
                            if (fields.Length >= 2)// Check if there are at least 2 fields (username and password)
                            {
                                string usernameInFile = fields[0].Trim(); // Trim whitespace
                                string passwordInFile = fields[1].Trim(); // Trim whitespace

                                // Simple standard string comparison using ==
                                if (usernameInFile == Username && passwordInFile == Password)
                                {
                                    isFound = true;

                                }
                            }
                        }
                        line = reader.ReadLine(); // Read next line
                    }
                    reader.Close(); // Step 3: Close file
                }
            }
            catch (Exception ex) // Catch block
            {
                MessageBox.Show("Error reading user file: " + ex.Message);
                if (reader != null)
                {
                    reader.Close(); // Ensure stream closes on error
                }
            }

            return isFound;
        }

        // Void method to save a new user (For Person 2 Register Form)
        //users management even for the newly registered users
        //this should be called by the person responsible for registration after validating the new user's credentials. It appends the new user's information (username, password, and role) to the Users.txt file.
        public void SaveUser(string username, string password, string role)
        {
            StreamWriter writer = null; // Declare StreamWriter

            try
            {
                // Open file in append mode (true)
                writer = new StreamWriter(usersPath, true);
                string record = username + "," + password + "," + role;

                writer.WriteLine(record); // Step 2: Write data
                writer.Close(); // Step 3: Close file
                MessageBox.Show("User registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user: " + ex.Message);
                if (writer != null)
                {
                    writer.Close(); // Ensure stream closes on error
                }
            }
        }

        // 2. PLAYLISTS FILE MANAGEMENT (Playlists.txt)
        // part of playlist management for the users, including loading and saving playlists
        // Void method to load playlists into a DataGridView (For Person 3 & Person 4)
        public void LoadPlaylistsToGrid(DataGridView dgvPlaylists)
        {
            StreamReader reader = null;
            dgvPlaylists.Rows.Clear(); // Clear existing rows

            try
            {
                if (File.Exists(playlistsPath)) // Check if file exists
                {
                    reader = new StreamReader(playlistsPath); // Open playlists file
                    string line = reader.ReadLine(); // Read first line

                    while (line != null)
                    {
                        if (line.Trim() != "")
                        {
                            string[] fields = line.Split(',');

                            if (fields.Length >= 3)
                            {
                                int rowIndex = dgvPlaylists.Rows.Add(); // Add row to grid
                                dgvPlaylists.Rows[rowIndex].Cells[0].Value = fields[0].Trim(); // Playlist ID
                                dgvPlaylists.Rows[rowIndex].Cells[1].Value = fields[1].Trim(); // Playlist Name
                                dgvPlaylists.Rows[rowIndex].Cells[2].Value = fields[2].Trim(); // Created By
                            }
                        }
                        line = reader.ReadLine();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading playlists: " + ex.Message);
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        // Void method to append a new playlist (For Person 3 Create Playlist)
        //to make things easier for person 3, this method allows them to save a new playlist to the Playlists.txt file by providing the playlist ID, name, and creator's username. It appends the new playlist information to the file.
        public void SavePlaylist(string playlistId, string playlistName, string createdBy)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(playlistsPath, true);
                string record = playlistId + "," + playlistName + "," + createdBy;

                writer.WriteLine(record);
                writer.Close();
                MessageBox.Show("Playlist created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving playlist: " + ex.Message);
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }


        // 3. SONGS FILE MANAGEMENT (Songs.txt)

        // Void method to load songs into a DataGridView (For Person 4 & Person 5)
        //person 5 can view the songs in the Songs.txt file using this method, which populates a DataGridView with the song information (songId, title, artist, duration, filePath) from the file.
        public void LoadSongsToGrid(DataGridView dgvSongs)
        {
            StreamReader reader = null;
            dgvSongs.Rows.Clear();

            try
            {
                if (File.Exists(songsPath)) // Check if file exists
                {
                    reader = new StreamReader(songsPath); // Open songs file
                    string line = reader.ReadLine(); // Read first line

                    while (line != null) // Read until end of file
                    {
                        if (line.Trim() != "") // Skip empty lines
                        {
                            string[] fields = line.Split(',');      // Split line into fields

                            if (fields.Length >= 5) // Ensure there are at least 5 fields (songId, title, artist, duration, filePath)
                            {
                                int rowIndex = dgvSongs.Rows.Add();
                                dgvSongs.Rows[rowIndex].Cells[0].Value = fields[0].Trim(); // Song ID
                                dgvSongs.Rows[rowIndex].Cells[1].Value = fields[1].Trim(); // Title
                                dgvSongs.Rows[rowIndex].Cells[2].Value = fields[2].Trim(); // Artist
                                dgvSongs.Rows[rowIndex].Cells[3].Value = fields[3].Trim(); // Duration
                                dgvSongs.Rows[rowIndex].Cells[4].Value = fields[4].Trim(); // File Path
                            }
                        }
                        line = reader.ReadLine();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading songs: " + ex.Message); //  Display error message
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        // Void method to save a new song (For Person 5 Upload Song)
        //person 5 can upload songs and save them to the Songs.txt file using this method
        //person 5 should call this method after selecting a song file and providing the necessary details (songId, title, artist, duration, filePath) to save the song information to the Songs.txt file.
        public void SaveSong(string songId, string title, string artist, string duration, string filePath)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(songsPath, true); // Open file in append mode
                string record = songId + "," + title + "," + artist + "," + duration + "," + filePath; // Create record string

                writer.WriteLine(record);
                writer.Close();
                MessageBox.Show("Song saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving song: " + ex.Message);
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        // Non-void method returning total file line counts (For Person 7 Statistics)
        public int GetTotalSongsCount()
        {
            StreamReader reader = null;
            int count = 0;

            try
            {
                if (File.Exists(songsPath)) // Check if file exists
                {
                    reader = new StreamReader(songsPath); // Open songs file
                    string line = reader.ReadLine(); // Read first line

                    while (line != null)
                    {
                        if (line.Trim() != "") // Skip empty lines
                        {
                            count++;
                        }
                        line = reader.ReadLine(); //    Read next line
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting songs: " + ex.Message); //  Display error message
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return count;
        }
    }
}