namespace Practical_1assignment
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.btnOpenPlaylist = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnNewPlaylist = new System.Windows.Forms.Button();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.gbxHeading = new System.Windows.Forms.GroupBox();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.pbCoverArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.gbxHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblWelcome.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(246, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome back, User!";
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.BackColor = System.Drawing.Color.SlateGray;
            this.lblPlaylistName.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.Color.White;
            this.lblPlaylistName.Location = new System.Drawing.Point(290, 341);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(112, 19);
            this.lblPlaylistName.TabIndex = 8;
            this.lblPlaylistName.Text = "Playlist name:";
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.BackColor = System.Drawing.Color.White;
            this.pbUserIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbUserIcon.Image")));
            this.pbUserIcon.Location = new System.Drawing.Point(17, 63);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(197, 210);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserIcon.TabIndex = 2;
            this.pbUserIcon.TabStop = false;
            // 
            // btnOpenPlaylist
            // 
            this.btnOpenPlaylist.BackColor = System.Drawing.Color.SlateGray;
            this.btnOpenPlaylist.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnOpenPlaylist.Location = new System.Drawing.Point(12, 322);
            this.btnOpenPlaylist.Name = "btnOpenPlaylist";
            this.btnOpenPlaylist.Size = new System.Drawing.Size(142, 38);
            this.btnOpenPlaylist.TabIndex = 3;
            this.btnOpenPlaylist.Text = "Open Playlist";
            this.btnOpenPlaylist.UseVisualStyleBackColor = false;
            this.btnOpenPlaylist.Click += new System.EventHandler(this.btnOpenPlaylist_Click_1);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.SlateGray;
            this.btnUpload.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(12, 386);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(142, 40);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload Song";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.BackColor = System.Drawing.Color.SlateGray;
            this.btnNewPlaylist.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnNewPlaylist.Location = new System.Drawing.Point(280, 386);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(142, 41);
            this.btnNewPlaylist.TabIndex = 4;
            this.btnNewPlaylist.Text = "New Playlist";
            this.btnNewPlaylist.UseVisualStyleBackColor = false;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click_1);
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(408, 337);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(248, 26);
            this.txtPlaylistName.TabIndex = 9;
            // 
            // gbxHeading
            // 
            this.gbxHeading.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxHeading.Controls.Add(this.pbCoverArt);
            this.gbxHeading.Controls.Add(this.lstPlaylists);
            this.gbxHeading.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHeading.ForeColor = System.Drawing.Color.White;
            this.gbxHeading.Location = new System.Drawing.Point(294, 49);
            this.gbxHeading.Name = "gbxHeading";
            this.gbxHeading.Size = new System.Drawing.Size(484, 271);
            this.gbxHeading.TabIndex = 7;
            this.gbxHeading.TabStop = false;
            this.gbxHeading.Text = "My Playlists";
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.BackColor = System.Drawing.Color.LightBlue;
            this.lstPlaylists.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlaylists.ForeColor = System.Drawing.Color.White;
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.ItemHeight = 24;
            this.lstPlaylists.Location = new System.Drawing.Point(22, 49);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(409, 196);
            this.lstPlaylists.TabIndex = 2;
            this.lstPlaylists.SelectedIndexChanged += new System.EventHandler(this.lstPlaylists_SelectedIndexChanged);
            // 
            // pbCoverArt
            // 
            this.pbCoverArt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbCoverArt.Location = new System.Drawing.Point(306, 62);
            this.pbCoverArt.Name = "pbCoverArt";
            this.pbCoverArt.Size = new System.Drawing.Size(100, 81);
            this.pbCoverArt.TabIndex = 8;
            this.pbCoverArt.TabStop = false;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxHeading);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnOpenPlaylist);
            this.Controls.Add(this.pbUserIcon);
            this.Controls.Add(this.lblPlaylistName);
            this.Controls.Add(this.lblWelcome);
            this.DoubleBuffered = true;
            this.Name = "frmHomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.gbxHeading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.Button btnOpenPlaylist;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnNewPlaylist;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.GroupBox gbxHeading;
        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.PictureBox pbCoverArt;
    }
}

