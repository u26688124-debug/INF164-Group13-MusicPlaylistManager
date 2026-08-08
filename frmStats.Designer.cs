using System.Reflection.Emit;

namespace Statistics_and_Testing
{
    partial class frmStats
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
        /// Required method for Designer support
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWrappedStatement = new System.Windows.Forms.Label();
            this.lblWrappedNumber = new System.Windows.Forms.Label();
            this.grpPeriod = new System.Windows.Forms.GroupBox();
            this.radWeek = new System.Windows.Forms.RadioButton();
            this.radMonth = new System.Windows.Forms.RadioButton();
            this.radYear = new System.Windows.Forms.RadioButton();
            this.radTotal = new System.Windows.Forms.RadioButton();
            this.btnArtist = new System.Windows.Forms.Button();
            this.btnSong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDurationDisplay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblWrappedStatement
            // 
            this.lblWrappedStatement.AutoSize = true;
            this.lblWrappedStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWrappedStatement.Location = new System.Drawing.Point(100, 50);
            this.lblWrappedStatement.Name = "lblWrappedStatement";
            this.lblWrappedStatement.Size = new System.Drawing.Size(205, 25);
            this.lblWrappedStatement.TabIndex = 1;
            this.lblWrappedStatement.Text = "Total Tracks in Library";
            // 
            // lblWrappedNumber
            // 
            this.lblWrappedNumber.AutoSize = true;
            this.lblWrappedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblWrappedNumber.Location = new System.Drawing.Point(100, 80);
            this.lblWrappedNumber.Name = "lblWrappedNumber";
            this.lblWrappedNumber.Size = new System.Drawing.Size(53, 58);
            this.lblWrappedNumber.TabIndex = 2;
            this.lblWrappedNumber.Text = "0";
            // 
            // grpPeriod
            // 
            this.grpPeriod.Controls.Add(this.radWeek);
            this.grpPeriod.Controls.Add(this.radMonth);
            this.grpPeriod.Controls.Add(this.radYear);
            this.grpPeriod.Controls.Add(this.radTotal);
            this.grpPeriod.Location = new System.Drawing.Point(36, 169);
            this.grpPeriod.Name = "grpPeriod";
            this.grpPeriod.Size = new System.Drawing.Size(575, 57);
            this.grpPeriod.TabIndex = 3;
            this.grpPeriod.TabStop = false;
            this.grpPeriod.Text = "Period:";
            // 
            // radWeek
            // 
            this.radWeek.AutoSize = true;
            this.radWeek.Location = new System.Drawing.Point(463, 31);
            this.radWeek.Name = "radWeek";
            this.radWeek.Size = new System.Drawing.Size(64, 20);
            this.radWeek.TabIndex = 3;
            this.radWeek.TabStop = true;
            this.radWeek.Text = "Week";
            this.radWeek.UseVisualStyleBackColor = true;
            // 
            // radMonth
            // 
            this.radMonth.AutoSize = true;
            this.radMonth.Location = new System.Drawing.Point(312, 31);
            this.radMonth.Name = "radMonth";
            this.radMonth.Size = new System.Drawing.Size(64, 20);
            this.radMonth.TabIndex = 2;
            this.radMonth.TabStop = true;
            this.radMonth.Text = "Month";
            this.radMonth.UseVisualStyleBackColor = true;
            // 
            // radYear
            // 
            this.radYear.AutoSize = true;
            this.radYear.Location = new System.Drawing.Point(173, 31);
            this.radYear.Name = "radYear";
            this.radYear.Size = new System.Drawing.Size(57, 20);
            this.radYear.TabIndex = 1;
            this.radYear.TabStop = true;
            this.radYear.Text = "Year";
            this.radYear.UseVisualStyleBackColor = true;
            // 
            // radTotal
            // 
            this.radTotal.AutoSize = true;
            this.radTotal.Location = new System.Drawing.Point(17, 31);
            this.radTotal.Name = "radTotal";
            this.radTotal.Size = new System.Drawing.Size(77, 20);
            this.radTotal.TabIndex = 0;
            this.radTotal.TabStop = true;
            this.radTotal.Text = "All Time";
            this.radTotal.UseVisualStyleBackColor = true;
            // 
            // btnArtist
            // 
            this.btnArtist.Location = new System.Drawing.Point(179, 247);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(87, 32);
            this.btnArtist.TabIndex = 4;
            this.btnArtist.Text = "Top Artist";
            this.btnArtist.UseVisualStyleBackColor = true;
            // 
            // btnSong
            // 
            this.btnSong.Location = new System.Drawing.Point(348, 247);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(87, 32);
            this.btnSong.TabIndex = 5;
            this.btnSong.Text = "Top Track";
            this.btnSong.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRank,
            this.colArtist,
            this.colImage,
            this.colGenre,
            this.colHours});
            this.dataGridView1.Location = new System.Drawing.Point(36, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "Rank";
            this.colRank.MinimumWidth = 6;
            this.colRank.Name = "colRank";
            this.colRank.Width = 125;
            // 
            // colArtist
            // 
            this.colArtist.HeaderText = "Artist Name";
            this.colArtist.MinimumWidth = 6;
            this.colArtist.Name = "colArtist";
            this.colArtist.Width = 125;
            // 
            // colImage
            // 
            this.colImage.HeaderText = "Image of Artist";
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.Width = 125;
            // 
            // colGenre
            // 
            this.colGenre.HeaderText = "Genre";
            this.colGenre.MinimumWidth = 6;
            this.colGenre.Name = "colGenre";
            this.colGenre.Width = 125;
            // 
            // colHours
            // 
            this.colHours.HeaderText = "Hours Played";
            this.colHours.MinimumWidth = 6;
            this.colHours.Name = "colHours";
            this.colHours.Width = 125;
            // 
            // lblDurationDisplay
            // 
            this.lblDurationDisplay.AutoSize = true;
            this.lblDurationDisplay.Location = new System.Drawing.Point(33, 450);
            this.lblDurationDisplay.Name = "lblDurationDisplay";
            this.lblDurationDisplay.Size = new System.Drawing.Size(44, 16);
            this.lblDurationDisplay.TabIndex = 7;
            this.lblDurationDisplay.Text = "label1";
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.lblDurationDisplay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSong);
            this.Controls.Add(this.btnArtist);
            this.Controls.Add(this.grpPeriod);
            this.Controls.Add(this.lblWrappedNumber);
            this.Controls.Add(this.lblWrappedStatement);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStats";
            this.Text = "My Wrapped";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPeriod.ResumeLayout(false);
            this.grpPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // Label for track count
            //
            this.lblWrappedNumber = new System.Windows.Forms.Label();
            this.lblWrappedNumber.AutoSize = true;
            this.lblWrappedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblWrappedNumber.Location = new System.Drawing.Point(100, 80);
            this.lblWrappedNumber.Name = "lblWrappedNumber";
            this.lblWrappedNumber.Size = new System.Drawing.Size(46, 46);
            this.lblWrappedNumber.TabIndex = 2;
            this.lblWrappedNumber.Text = "0";
            //
            // Label for description
            //
            this.lblWrappedStatement = new System.Windows.Forms.Label();
            this.lblWrappedStatement.AutoSize = true;
            this.lblWrappedStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWrappedStatement.Location = new System.Drawing.Point(100, 50);
            this.lblWrappedStatement.Name = "lblWrappedStatement";
            this.lblWrappedStatement.Size = new System.Drawing.Size(150, 20);
            this.lblWrappedStatement.TabIndex = 1;
            this.lblWrappedStatement.Text = "Total Tracks in Library";
            //
            //
            
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblWrappedStatement;
        private System.Windows.Forms.Label lblWrappedNumber;
        private System.Windows.Forms.GroupBox grpPeriod;
        private System.Windows.Forms.RadioButton radWeek;
        private System.Windows.Forms.RadioButton radMonth;
        private System.Windows.Forms.RadioButton radYear;
        private System.Windows.Forms.RadioButton radTotal;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnSong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHours;
        private System.Windows.Forms.Label lblDurationDisplay;
    }
}