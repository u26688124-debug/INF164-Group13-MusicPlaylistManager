namespace Statistics_and_Testing
{
    partial class frmLibrary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalSongs = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myWrappedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colSong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.rtbPlaylistBio = new System.Windows.Forms.RichTextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.AutoSize = true;
            this.lblTotalSongs.Location = new System.Drawing.Point(219, 412);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(111, 16);
            this.lblTotalSongs.TabIndex = 0;
            this.lblTotalSongs.Text = "Number of Songs";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(448, 412);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(57, 16);
            this.lblDuration.TabIndex = 1;
            this.lblDuration.Text = "Duration";
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(282, 59);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(112, 39);
            this.lblPlaylistName.TabIndex = 2;
            this.lblPlaylistName.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myWrappedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myWrappedToolStripMenuItem
            // 
            this.myWrappedToolStripMenuItem.Name = "myWrappedToolStripMenuItem";
            this.myWrappedToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.myWrappedToolStripMenuItem.Text = "My Wrapped";
            this.myWrappedToolStripMenuItem.Click += new System.EventHandler(this.myWrappedToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSong,
            this.colArtist,
            this.colLength});
            this.dataGridView1.Location = new System.Drawing.Point(165, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(430, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // colSong
            // 
            this.colSong.HeaderText = "Song Name";
            this.colSong.MinimumWidth = 6;
            this.colSong.Name = "colSong";
            this.colSong.Width = 125;
            // 
            // colArtist
            // 
            this.colArtist.HeaderText = "Artist";
            this.colArtist.MinimumWidth = 6;
            this.colArtist.Name = "colArtist";
            this.colArtist.Width = 125;
            // 
            // colLength
            // 
            this.colLength.HeaderText = "Length";
            this.colLength.MinimumWidth = 6;
            this.colLength.Name = "colLength";
            this.colLength.Width = 125;
            // 
            // lblLibrary
            // 
            this.lblLibrary.AutoSize = true;
            this.lblLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrary.Location = new System.Drawing.Point(12, 38);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(61, 20);
            this.lblLibrary.TabIndex = 6;
            this.lblLibrary.Text = "Library";
            // 
            // rtbPlaylistBio
            // 
            this.rtbPlaylistBio.Location = new System.Drawing.Point(29, 101);
            this.rtbPlaylistBio.Name = "rtbPlaylistBio";
            this.rtbPlaylistBio.Size = new System.Drawing.Size(665, 46);
            this.rtbPlaylistBio.TabIndex = 7;
            this.rtbPlaylistBio.Text = "";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(305, 179);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.rtbPlaylistBio);
            this.Controls.Add(this.lblLibrary);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblTotalSongs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLibrary";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalSongs;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myWrappedToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLength;
        private System.Windows.Forms.Label lblLibrary;
        private System.Windows.Forms.RichTextBox rtbPlaylistBio;
        private System.Windows.Forms.Button btnPlay;
    }
}

