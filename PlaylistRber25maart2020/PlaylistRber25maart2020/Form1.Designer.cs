namespace PlaylistRber25maart2020
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mnsMenuStripRber = new System.Windows.Forms.MenuStrip();
            this.mniSettingsRber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddSongRber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSavePlaylistRber = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoadPlaylistRber = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAboutRber = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExitRber = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxListBoxRber = new System.Windows.Forms.ListBox();
            this.lblCurrentlyPlayingRber = new System.Windows.Forms.Label();
            this.btnShuffleListRber = new System.Windows.Forms.Button();
            this.btnShuffleSongRber = new System.Windows.Forms.Button();
            this.btnAddSongRber = new System.Windows.Forms.Button();
            this.btnPlaySongRber = new System.Windows.Forms.Button();
            this.btnStopSongRber = new System.Windows.Forms.Button();
            this.btnSaveSonglistRber = new System.Windows.Forms.Button();
            this.btnLoadsonglistRber = new System.Windows.Forms.Button();
            this.btnPauseSongRber = new System.Windows.Forms.Button();
            this.btnNextSongRber = new System.Windows.Forms.Button();
            this.btnPreviousSongRber = new System.Windows.Forms.Button();
            this.lblCurrentSongRber = new System.Windows.Forms.Label();
            this.lblSearchRber = new System.Windows.Forms.Label();
            this.txbSearchRber = new System.Windows.Forms.TextBox();
            this.pgbPlayingSongRber = new System.Windows.Forms.ProgressBar();
            this.tcbPlayingSongRber = new System.Windows.Forms.TrackBar();
            this.ofdDialogRber = new System.Windows.Forms.OpenFileDialog();
            this.tmrTimerRber = new System.Windows.Forms.Timer(this.components);
            this.mnsMenuStripRber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcbPlayingSongRber)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMenuStripRber
            // 
            this.mnsMenuStripRber.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenuStripRber.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSettingsRber,
            this.mniAboutRber,
            this.mniExitRber});
            this.mnsMenuStripRber.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuStripRber.Name = "mnsMenuStripRber";
            this.mnsMenuStripRber.Size = new System.Drawing.Size(1187, 28);
            this.mnsMenuStripRber.TabIndex = 0;
            this.mnsMenuStripRber.Text = "menuStrip1";
            // 
            // mniSettingsRber
            // 
            this.mniSettingsRber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddSongRber,
            this.tsmSavePlaylistRber,
            this.tsmLoadPlaylistRber});
            this.mniSettingsRber.Name = "mniSettingsRber";
            this.mniSettingsRber.Size = new System.Drawing.Size(76, 24);
            this.mniSettingsRber.Text = "Settings";
            // 
            // tsmAddSongRber
            // 
            this.tsmAddSongRber.Name = "tsmAddSongRber";
            this.tsmAddSongRber.Size = new System.Drawing.Size(176, 26);
            this.tsmAddSongRber.Text = "Add song";
            this.tsmAddSongRber.Click += new System.EventHandler(this.tsmAddSongRber_Click);
            // 
            // tsmSavePlaylistRber
            // 
            this.tsmSavePlaylistRber.Name = "tsmSavePlaylistRber";
            this.tsmSavePlaylistRber.Size = new System.Drawing.Size(176, 26);
            this.tsmSavePlaylistRber.Text = "Save playlist";
            this.tsmSavePlaylistRber.Click += new System.EventHandler(this.tsmSavePlaylistRber_Click);
            // 
            // tsmLoadPlaylistRber
            // 
            this.tsmLoadPlaylistRber.Name = "tsmLoadPlaylistRber";
            this.tsmLoadPlaylistRber.Size = new System.Drawing.Size(176, 26);
            this.tsmLoadPlaylistRber.Text = "Load playlist";
            this.tsmLoadPlaylistRber.Click += new System.EventHandler(this.tsmLoadPlaylistRber_Click);
            // 
            // mniAboutRber
            // 
            this.mniAboutRber.Name = "mniAboutRber";
            this.mniAboutRber.Size = new System.Drawing.Size(64, 24);
            this.mniAboutRber.Text = "About";
            this.mniAboutRber.Click += new System.EventHandler(this.mniAboutRber_Click);
            // 
            // mniExitRber
            // 
            this.mniExitRber.Name = "mniExitRber";
            this.mniExitRber.Size = new System.Drawing.Size(47, 24);
            this.mniExitRber.Text = "Exit";
            this.mniExitRber.Click += new System.EventHandler(this.mniExitRber_Click);
            // 
            // lbxListBoxRber
            // 
            this.lbxListBoxRber.FormattingEnabled = true;
            this.lbxListBoxRber.ItemHeight = 16;
            this.lbxListBoxRber.Location = new System.Drawing.Point(127, 70);
            this.lbxListBoxRber.Name = "lbxListBoxRber";
            this.lbxListBoxRber.Size = new System.Drawing.Size(1048, 340);
            this.lbxListBoxRber.TabIndex = 1;
            this.lbxListBoxRber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxListBoxRber_MouseClick);
            this.lbxListBoxRber.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxListBoxRber_MouseDoubleClick);
            // 
            // lblCurrentlyPlayingRber
            // 
            this.lblCurrentlyPlayingRber.AutoSize = true;
            this.lblCurrentlyPlayingRber.Location = new System.Drawing.Point(137, 40);
            this.lblCurrentlyPlayingRber.Name = "lblCurrentlyPlayingRber";
            this.lblCurrentlyPlayingRber.Size = new System.Drawing.Size(118, 17);
            this.lblCurrentlyPlayingRber.TabIndex = 2;
            this.lblCurrentlyPlayingRber.Text = "Currently playing:";
            // 
            // btnShuffleListRber
            // 
            this.btnShuffleListRber.Location = new System.Drawing.Point(958, 33);
            this.btnShuffleListRber.Name = "btnShuffleListRber";
            this.btnShuffleListRber.Size = new System.Drawing.Size(108, 32);
            this.btnShuffleListRber.TabIndex = 3;
            this.btnShuffleListRber.Text = "Shuffle list";
            this.btnShuffleListRber.UseVisualStyleBackColor = true;
            this.btnShuffleListRber.Click += new System.EventHandler(this.btnShuffleListRber_Click);
            // 
            // btnShuffleSongRber
            // 
            this.btnShuffleSongRber.Location = new System.Drawing.Point(1072, 33);
            this.btnShuffleSongRber.Name = "btnShuffleSongRber";
            this.btnShuffleSongRber.Size = new System.Drawing.Size(103, 31);
            this.btnShuffleSongRber.TabIndex = 4;
            this.btnShuffleSongRber.Text = "Shuffle song";
            this.btnShuffleSongRber.UseVisualStyleBackColor = true;
            this.btnShuffleSongRber.Click += new System.EventHandler(this.btnShuffleSongRber_Click);
            // 
            // btnAddSongRber
            // 
            this.btnAddSongRber.Location = new System.Drawing.Point(8, 70);
            this.btnAddSongRber.Name = "btnAddSongRber";
            this.btnAddSongRber.Size = new System.Drawing.Size(108, 39);
            this.btnAddSongRber.TabIndex = 5;
            this.btnAddSongRber.Text = "Add song";
            this.btnAddSongRber.UseVisualStyleBackColor = true;
            this.btnAddSongRber.Click += new System.EventHandler(this.btnAddSongRber_Click);
            // 
            // btnPlaySongRber
            // 
            this.btnPlaySongRber.Location = new System.Drawing.Point(8, 115);
            this.btnPlaySongRber.Name = "btnPlaySongRber";
            this.btnPlaySongRber.Size = new System.Drawing.Size(108, 41);
            this.btnPlaySongRber.TabIndex = 6;
            this.btnPlaySongRber.Text = "Play song";
            this.btnPlaySongRber.UseVisualStyleBackColor = true;
            this.btnPlaySongRber.Click += new System.EventHandler(this.btnPlaySongRber_Click);
            // 
            // btnStopSongRber
            // 
            this.btnStopSongRber.Location = new System.Drawing.Point(8, 162);
            this.btnStopSongRber.Name = "btnStopSongRber";
            this.btnStopSongRber.Size = new System.Drawing.Size(108, 46);
            this.btnStopSongRber.TabIndex = 7;
            this.btnStopSongRber.Text = "Stop song";
            this.btnStopSongRber.UseVisualStyleBackColor = true;
            this.btnStopSongRber.Click += new System.EventHandler(this.btnStopSongRber_Click);
            // 
            // btnSaveSonglistRber
            // 
            this.btnSaveSonglistRber.Location = new System.Drawing.Point(8, 214);
            this.btnSaveSonglistRber.Name = "btnSaveSonglistRber";
            this.btnSaveSonglistRber.Size = new System.Drawing.Size(108, 44);
            this.btnSaveSonglistRber.TabIndex = 8;
            this.btnSaveSonglistRber.Text = "Save songlist";
            this.btnSaveSonglistRber.UseVisualStyleBackColor = true;
            this.btnSaveSonglistRber.Click += new System.EventHandler(this.btnSaveSonglistRber_Click);
            // 
            // btnLoadsonglistRber
            // 
            this.btnLoadsonglistRber.Location = new System.Drawing.Point(8, 264);
            this.btnLoadsonglistRber.Name = "btnLoadsonglistRber";
            this.btnLoadsonglistRber.Size = new System.Drawing.Size(108, 42);
            this.btnLoadsonglistRber.TabIndex = 9;
            this.btnLoadsonglistRber.Text = "Load songlist";
            this.btnLoadsonglistRber.UseVisualStyleBackColor = true;
            this.btnLoadsonglistRber.Click += new System.EventHandler(this.btnLoadsonglistRber_Click);
            // 
            // btnPauseSongRber
            // 
            this.btnPauseSongRber.Location = new System.Drawing.Point(8, 312);
            this.btnPauseSongRber.Name = "btnPauseSongRber";
            this.btnPauseSongRber.Size = new System.Drawing.Size(108, 40);
            this.btnPauseSongRber.TabIndex = 10;
            this.btnPauseSongRber.Text = "Pause song";
            this.btnPauseSongRber.UseVisualStyleBackColor = true;
            this.btnPauseSongRber.Click += new System.EventHandler(this.btnPauseSongRber_Click);
            // 
            // btnNextSongRber
            // 
            this.btnNextSongRber.Location = new System.Drawing.Point(8, 358);
            this.btnNextSongRber.Name = "btnNextSongRber";
            this.btnNextSongRber.Size = new System.Drawing.Size(108, 47);
            this.btnNextSongRber.TabIndex = 11;
            this.btnNextSongRber.Text = "Next song";
            this.btnNextSongRber.UseVisualStyleBackColor = true;
            this.btnNextSongRber.Click += new System.EventHandler(this.btnNextSongRber_Click);
            // 
            // btnPreviousSongRber
            // 
            this.btnPreviousSongRber.Location = new System.Drawing.Point(8, 411);
            this.btnPreviousSongRber.Name = "btnPreviousSongRber";
            this.btnPreviousSongRber.Size = new System.Drawing.Size(108, 46);
            this.btnPreviousSongRber.TabIndex = 12;
            this.btnPreviousSongRber.Text = "Previous song";
            this.btnPreviousSongRber.UseVisualStyleBackColor = true;
            this.btnPreviousSongRber.Click += new System.EventHandler(this.btnPreviousSongRber_Click);
            // 
            // lblCurrentSongRber
            // 
            this.lblCurrentSongRber.AutoSize = true;
            this.lblCurrentSongRber.Location = new System.Drawing.Point(249, 40);
            this.lblCurrentSongRber.Name = "lblCurrentSongRber";
            this.lblCurrentSongRber.Size = new System.Drawing.Size(20, 17);
            this.lblCurrentSongRber.TabIndex = 13;
            this.lblCurrentSongRber.Text = "...";
            // 
            // lblSearchRber
            // 
            this.lblSearchRber.AutoSize = true;
            this.lblSearchRber.Location = new System.Drawing.Point(12, 471);
            this.lblSearchRber.Name = "lblSearchRber";
            this.lblSearchRber.Size = new System.Drawing.Size(57, 17);
            this.lblSearchRber.TabIndex = 14;
            this.lblSearchRber.Text = "Search:";
            // 
            // txbSearchRber
            // 
            this.txbSearchRber.Location = new System.Drawing.Point(15, 491);
            this.txbSearchRber.Name = "txbSearchRber";
            this.txbSearchRber.Size = new System.Drawing.Size(100, 22);
            this.txbSearchRber.TabIndex = 15;
            this.txbSearchRber.TextChanged += new System.EventHandler(this.txbSearchRber_TextChanged);
            // 
            // pgbPlayingSongRber
            // 
            this.pgbPlayingSongRber.Location = new System.Drawing.Point(127, 473);
            this.pgbPlayingSongRber.Name = "pgbPlayingSongRber";
            this.pgbPlayingSongRber.Size = new System.Drawing.Size(1048, 40);
            this.pgbPlayingSongRber.TabIndex = 16;
            // 
            // tcbPlayingSongRber
            // 
            this.tcbPlayingSongRber.Location = new System.Drawing.Point(127, 416);
            this.tcbPlayingSongRber.Name = "tcbPlayingSongRber";
            this.tcbPlayingSongRber.Size = new System.Drawing.Size(1048, 56);
            this.tcbPlayingSongRber.TabIndex = 17;
            // 
            // ofdDialogRber
            // 
            this.ofdDialogRber.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 525);
            this.Controls.Add(this.tcbPlayingSongRber);
            this.Controls.Add(this.pgbPlayingSongRber);
            this.Controls.Add(this.txbSearchRber);
            this.Controls.Add(this.lblSearchRber);
            this.Controls.Add(this.lblCurrentSongRber);
            this.Controls.Add(this.btnPreviousSongRber);
            this.Controls.Add(this.btnNextSongRber);
            this.Controls.Add(this.btnPauseSongRber);
            this.Controls.Add(this.btnLoadsonglistRber);
            this.Controls.Add(this.btnSaveSonglistRber);
            this.Controls.Add(this.btnStopSongRber);
            this.Controls.Add(this.btnPlaySongRber);
            this.Controls.Add(this.btnAddSongRber);
            this.Controls.Add(this.btnShuffleSongRber);
            this.Controls.Add(this.btnShuffleListRber);
            this.Controls.Add(this.lblCurrentlyPlayingRber);
            this.Controls.Add(this.lbxListBoxRber);
            this.Controls.Add(this.mnsMenuStripRber);
            this.MainMenuStrip = this.mnsMenuStripRber;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnsMenuStripRber.ResumeLayout(false);
            this.mnsMenuStripRber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcbPlayingSongRber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenuStripRber;
        private System.Windows.Forms.ToolStripMenuItem mniSettingsRber;
        private System.Windows.Forms.ToolStripMenuItem mniAboutRber;
        private System.Windows.Forms.ListBox lbxListBoxRber;
        private System.Windows.Forms.Label lblCurrentlyPlayingRber;
        private System.Windows.Forms.Button btnShuffleListRber;
        private System.Windows.Forms.Button btnShuffleSongRber;
        private System.Windows.Forms.Button btnAddSongRber;
        private System.Windows.Forms.Button btnPlaySongRber;
        private System.Windows.Forms.Button btnStopSongRber;
        private System.Windows.Forms.Button btnSaveSonglistRber;
        private System.Windows.Forms.Button btnLoadsonglistRber;
        private System.Windows.Forms.Button btnPauseSongRber;
        private System.Windows.Forms.Button btnNextSongRber;
        private System.Windows.Forms.Button btnPreviousSongRber;
        private System.Windows.Forms.Label lblCurrentSongRber;
        private System.Windows.Forms.Label lblSearchRber;
        private System.Windows.Forms.TextBox txbSearchRber;
        private System.Windows.Forms.ProgressBar pgbPlayingSongRber;
        private System.Windows.Forms.TrackBar tcbPlayingSongRber;
        private System.Windows.Forms.ToolStripMenuItem mniExitRber;
        private System.Windows.Forms.OpenFileDialog ofdDialogRber;
        private System.Windows.Forms.ToolStripMenuItem tsmAddSongRber;
        private System.Windows.Forms.ToolStripMenuItem tsmSavePlaylistRber;
        private System.Windows.Forms.ToolStripMenuItem tsmLoadPlaylistRber;
        private System.Windows.Forms.Timer tmrTimerRber;
    }
}

