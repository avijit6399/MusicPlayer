namespace MusicPlayer_1._0
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.fastForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastBackwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.stopImage2 = new System.Windows.Forms.PictureBox();
            this.stopImage1 = new System.Windows.Forms.PictureBox();
            this.playImage1 = new System.Windows.Forms.PictureBox();
            this.pauseImage1 = new System.Windows.Forms.PictureBox();
            this.forwardImage2 = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectedSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllSongsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.savePlaylistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardImage1 = new System.Windows.Forms.PictureBox();
            this.fastBackward2 = new System.Windows.Forms.PictureBox();
            this.fastBackward1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).BeginInit();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forwardImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastBackward2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastBackward1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mPlayer
            // 
            this.mPlayer.AllowDrop = true;
            this.mPlayer.CausesValidation = false;
            this.mPlayer.Enabled = true;
            this.mPlayer.Location = new System.Drawing.Point(0, 24);
            this.mPlayer.Name = "mPlayer";
            this.mPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mPlayer.OcxState")));
            this.mPlayer.Size = new System.Drawing.Size(663, 400);
            this.mPlayer.TabIndex = 0;
            this.mPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mPlayer_PlayStateChange);
            this.mPlayer.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.mPlayer_PositionChange);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.userInformationToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1012, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.openToolStripMenuItem.Text = "&Open Media File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripMenuItem3,
            this.fastForwardToolStripMenuItem,
            this.fastBackwardToolStripMenuItem,
            this.toolStripMenuItem2});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.controlToolStripMenuItem.Text = "&Controls";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.playToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.playToolStripMenuItem.Text = "&Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.stopToolStripMenuItem.Text = "&Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pauseToolStripMenuItem.Text = "Pa&use";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 6);
            // 
            // fastForwardToolStripMenuItem
            // 
            this.fastForwardToolStripMenuItem.Name = "fastForwardToolStripMenuItem";
            this.fastForwardToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fastForwardToolStripMenuItem.Text = "Fast &Forward";
            this.fastForwardToolStripMenuItem.Click += new System.EventHandler(this.fastForwardToolStripMenuItem_Click);
            // 
            // fastBackwardToolStripMenuItem
            // 
            this.fastBackwardToolStripMenuItem.Name = "fastBackwardToolStripMenuItem";
            this.fastBackwardToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fastBackwardToolStripMenuItem.Text = "Fast &Backward";
            this.fastBackwardToolStripMenuItem.Click += new System.EventHandler(this.fastBackwardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.removeSongToolStripMenuItem,
            this.removeAllSongsToolStripMenuItem,
            this.toolStripMenuItem5,
            this.savePlaylistToolStripMenuItem});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // addSongsToolStripMenuItem
            // 
            this.addSongsToolStripMenuItem.Name = "addSongsToolStripMenuItem";
            this.addSongsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.addSongsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.addSongsToolStripMenuItem.Text = "Add Songs";
            this.addSongsToolStripMenuItem.Click += new System.EventHandler(this.addSongsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(239, 6);
            // 
            // removeSongToolStripMenuItem
            // 
            this.removeSongToolStripMenuItem.Name = "removeSongToolStripMenuItem";
            this.removeSongToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.removeSongToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.removeSongToolStripMenuItem.Text = "Remove Selected Song";
            // 
            // removeAllSongsToolStripMenuItem
            // 
            this.removeAllSongsToolStripMenuItem.Name = "removeAllSongsToolStripMenuItem";
            this.removeAllSongsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.removeAllSongsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.removeAllSongsToolStripMenuItem.Text = "Remove All Songs";
            this.removeAllSongsToolStripMenuItem.Click += new System.EventHandler(this.removeAllSongsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(239, 6);
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.savePlaylistToolStripMenuItem.Text = "Save Playlist";
            this.savePlaylistToolStripMenuItem.Click += new System.EventHandler(this.savePlaylistToolStripMenuItem_Click);
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.addUserToolStripMenuItem1});
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.userInformationToolStripMenuItem.Text = "User Information";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addUserToolStripMenuItem.Text = "Update Password";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem1
            // 
            this.addUserToolStripMenuItem1.Name = "addUserToolStripMenuItem1";
            this.addUserToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.addUserToolStripMenuItem1.Text = "Add User";
            this.addUserToolStripMenuItem1.Click += new System.EventHandler(this.addUserToolStripMenuItem1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // stopImage2
            // 
            this.stopImage2.Image = ((System.Drawing.Image)(resources.GetObject("stopImage2.Image")));
            this.stopImage2.Location = new System.Drawing.Point(265, 472);
            this.stopImage2.Name = "stopImage2";
            this.stopImage2.Size = new System.Drawing.Size(49, 49);
            this.stopImage2.TabIndex = 3;
            this.stopImage2.TabStop = false;
            this.stopImage2.Click += new System.EventHandler(this.stopImage2_Click);
            this.stopImage2.MouseLeave += new System.EventHandler(this.stopImage2_MouseLeave);
            // 
            // stopImage1
            // 
            this.stopImage1.Image = ((System.Drawing.Image)(resources.GetObject("stopImage1.Image")));
            this.stopImage1.Location = new System.Drawing.Point(265, 472);
            this.stopImage1.Name = "stopImage1";
            this.stopImage1.Size = new System.Drawing.Size(49, 49);
            this.stopImage1.TabIndex = 4;
            this.stopImage1.TabStop = false;
            this.stopImage1.Click += new System.EventHandler(this.stopImage1_Click);
            this.stopImage1.MouseHover += new System.EventHandler(this.stopImage1_MouseHover);
            // 
            // playImage1
            // 
            this.playImage1.Image = ((System.Drawing.Image)(resources.GetObject("playImage1.Image")));
            this.playImage1.Location = new System.Drawing.Point(320, 472);
            this.playImage1.Name = "playImage1";
            this.playImage1.Size = new System.Drawing.Size(49, 49);
            this.playImage1.TabIndex = 5;
            this.playImage1.TabStop = false;
            this.playImage1.Click += new System.EventHandler(this.playImage1_Click);
            // 
            // pauseImage1
            // 
            this.pauseImage1.Image = ((System.Drawing.Image)(resources.GetObject("pauseImage1.Image")));
            this.pauseImage1.Location = new System.Drawing.Point(320, 472);
            this.pauseImage1.Name = "pauseImage1";
            this.pauseImage1.Size = new System.Drawing.Size(49, 49);
            this.pauseImage1.TabIndex = 6;
            this.pauseImage1.TabStop = false;
            this.pauseImage1.Click += new System.EventHandler(this.pauseImage1_Click);
            // 
            // forwardImage2
            // 
            this.forwardImage2.Image = ((System.Drawing.Image)(resources.GetObject("forwardImage2.Image")));
            this.forwardImage2.Location = new System.Drawing.Point(375, 472);
            this.forwardImage2.Name = "forwardImage2";
            this.forwardImage2.Size = new System.Drawing.Size(49, 49);
            this.forwardImage2.TabIndex = 7;
            this.forwardImage2.TabStop = false;
            this.forwardImage2.Click += new System.EventHandler(this.forwardImage2_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(21, 430);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(628, 45);
            this.trackBar.TabIndex = 9;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(669, 430);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 48);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSongs.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxSongs.ForeColor = System.Drawing.Color.Lime;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(669, 47);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(340, 377);
            this.listBoxSongs.TabIndex = 11;
            this.listBoxSongs.DoubleClick += new System.EventHandler(this.listBoxSongs_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripMenuItem6,
            this.removeSelectedSongToolStripMenuItem,
            this.removeAllSongsToolStripMenuItem1,
            this.toolStripMenuItem7,
            this.savePlaylistToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 104);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addToolStripMenuItem.Text = "Add Songs";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(191, 6);
            // 
            // removeSelectedSongToolStripMenuItem
            // 
            this.removeSelectedSongToolStripMenuItem.Name = "removeSelectedSongToolStripMenuItem";
            this.removeSelectedSongToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.removeSelectedSongToolStripMenuItem.Text = "Remove Selected Song";
            this.removeSelectedSongToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedSongToolStripMenuItem_Click);
            // 
            // removeAllSongsToolStripMenuItem1
            // 
            this.removeAllSongsToolStripMenuItem1.Name = "removeAllSongsToolStripMenuItem1";
            this.removeAllSongsToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.removeAllSongsToolStripMenuItem1.Text = "Remove All Songs";
            this.removeAllSongsToolStripMenuItem1.Click += new System.EventHandler(this.removeAllSongsToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(191, 6);
            // 
            // savePlaylistToolStripMenuItem1
            // 
            this.savePlaylistToolStripMenuItem1.Name = "savePlaylistToolStripMenuItem1";
            this.savePlaylistToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.savePlaylistToolStripMenuItem1.Text = "Save Playlist";
            this.savePlaylistToolStripMenuItem1.Click += new System.EventHandler(this.savePlaylistToolStripMenuItem1_Click);
            // 
            // forwardImage1
            // 
            this.forwardImage1.Image = ((System.Drawing.Image)(resources.GetObject("forwardImage1.Image")));
            this.forwardImage1.Location = new System.Drawing.Point(375, 472);
            this.forwardImage1.Name = "forwardImage1";
            this.forwardImage1.Size = new System.Drawing.Size(49, 49);
            this.forwardImage1.TabIndex = 12;
            this.forwardImage1.TabStop = false;
            this.forwardImage1.Click += new System.EventHandler(this.forwardImage1_Click);
            // 
            // fastBackward2
            // 
            this.fastBackward2.Image = ((System.Drawing.Image)(resources.GetObject("fastBackward2.Image")));
            this.fastBackward2.Location = new System.Drawing.Point(210, 472);
            this.fastBackward2.Name = "fastBackward2";
            this.fastBackward2.Size = new System.Drawing.Size(49, 49);
            this.fastBackward2.TabIndex = 13;
            this.fastBackward2.TabStop = false;
            this.fastBackward2.Click += new System.EventHandler(this.fastBackward2_Click);
            // 
            // fastBackward1
            // 
            this.fastBackward1.Image = ((System.Drawing.Image)(resources.GetObject("fastBackward1.Image")));
            this.fastBackward1.Location = new System.Drawing.Point(210, 472);
            this.fastBackward1.Name = "fastBackward1";
            this.fastBackward1.Size = new System.Drawing.Size(49, 49);
            this.fastBackward1.TabIndex = 14;
            this.fastBackward1.TabStop = false;
            this.fastBackward1.Click += new System.EventHandler(this.fastBackward1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(149, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "PlayList";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(669, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 27);
            this.panel1.TabIndex = 16;
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 533);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fastBackward1);
            this.Controls.Add(this.fastBackward2);
            this.Controls.Add(this.forwardImage1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.forwardImage2);
            this.Controls.Add(this.playImage1);
            this.Controls.Add(this.pauseImage1);
            this.Controls.Add(this.stopImage1);
            this.Controls.Add(this.stopImage2);
            this.Controls.Add(this.mPlayer);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.trackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player 1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forwardImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastBackward2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastBackward1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public AxWMPLib.AxWindowsMediaPlayer mPlayer;
        private System.Windows.Forms.PictureBox stopImage2;
        private System.Windows.Forms.PictureBox stopImage1;
        private System.Windows.Forms.PictureBox playImage1;
        private System.Windows.Forms.PictureBox pauseImage1;
        private System.Windows.Forms.PictureBox forwardImage2;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastForwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastBackwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeAllSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllSongsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem1;
        private System.Windows.Forms.PictureBox forwardImage1;
        private System.Windows.Forms.PictureBox fastBackward2;
        private System.Windows.Forms.PictureBox fastBackward1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem1;
    }
}

