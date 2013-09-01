namespace CoH2ReplayTools
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listReplays = new System.Windows.Forms.ListBox();
            this.buttonReplay = new System.Windows.Forms.Button();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.gridTeam1 = new System.Windows.Forms.DataGridView();
            this.gridTeam2 = new System.Windows.Forms.DataGridView();
            this.replayInfo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.oneFaction = new System.Windows.Forms.DataGridViewImageColumn();
            this.oneName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.oneCPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneSteamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twoFaction = new System.Windows.Forms.DataGridViewImageColumn();
            this.twoName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.twoCPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twoSteamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tooltipPlaybackDir = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenu.Size = new System.Drawing.Size(423, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // listReplays
            // 
            this.listReplays.FormattingEnabled = true;
            this.listReplays.HorizontalScrollbar = true;
            this.listReplays.Items.AddRange(new object[] {
            "Set playback directory"});
            this.listReplays.Location = new System.Drawing.Point(12, 85);
            this.listReplays.Name = "listReplays";
            this.listReplays.Size = new System.Drawing.Size(136, 355);
            this.listReplays.TabIndex = 1;
            this.listReplays.SelectedIndexChanged += new System.EventHandler(this.listReplays_SelectedIndexChanged);
            // 
            // buttonReplay
            // 
            this.buttonReplay.Enabled = false;
            this.buttonReplay.Location = new System.Drawing.Point(12, 27);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(136, 23);
            this.buttonReplay.TabIndex = 2;
            this.buttonReplay.Text = "Select a Replay...";
            this.buttonReplay.UseVisualStyleBackColor = true;
            // 
            // buttonDirectory
            // 
            this.buttonDirectory.Location = new System.Drawing.Point(12, 56);
            this.buttonDirectory.Name = "buttonDirectory";
            this.buttonDirectory.Size = new System.Drawing.Size(113, 23);
            this.buttonDirectory.TabIndex = 3;
            this.buttonDirectory.Text = "Playback Directory...";
            this.tooltipPlaybackDir.SetToolTip(this.buttonDirectory, "Click to select your CoH2 playback directory.");
            this.buttonDirectory.UseVisualStyleBackColor = true;
            this.buttonDirectory.Click += new System.EventHandler(this.buttonDirectory_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(125, 56);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(23, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "R";
            this.tooltipPlaybackDir.SetToolTip(this.buttonRefresh, "Click to refresh playback directory.");
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // gridTeam1
            // 
            this.gridTeam1.AllowUserToAddRows = false;
            this.gridTeam1.AllowUserToDeleteRows = false;
            this.gridTeam1.AllowUserToResizeColumns = false;
            this.gridTeam1.AllowUserToResizeRows = false;
            this.gridTeam1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeam1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oneFaction,
            this.oneName,
            this.oneCPM,
            this.oneSteamID});
            this.gridTeam1.Location = new System.Drawing.Point(165, 85);
            this.gridTeam1.Name = "gridTeam1";
            this.gridTeam1.ReadOnly = true;
            this.gridTeam1.RowHeadersVisible = false;
            this.gridTeam1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.gridTeam1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridTeam1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridTeam1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTeam1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridTeam1.Size = new System.Drawing.Size(248, 110);
            this.gridTeam1.TabIndex = 5;
            this.gridTeam1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTeam1_CellContentClick);
            // 
            // gridTeam2
            // 
            this.gridTeam2.AllowUserToAddRows = false;
            this.gridTeam2.AllowUserToDeleteRows = false;
            this.gridTeam2.AllowUserToResizeColumns = false;
            this.gridTeam2.AllowUserToResizeRows = false;
            this.gridTeam2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeam2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.twoFaction,
            this.twoName,
            this.twoCPM,
            this.twoSteamID});
            this.gridTeam2.Location = new System.Drawing.Point(165, 201);
            this.gridTeam2.Name = "gridTeam2";
            this.gridTeam2.ReadOnly = true;
            this.gridTeam2.RowHeadersVisible = false;
            this.gridTeam2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridTeam2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridTeam2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTeam2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridTeam2.Size = new System.Drawing.Size(248, 110);
            this.gridTeam2.TabIndex = 6;
            this.gridTeam2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTeam2_CellContentClick);
            // 
            // replayInfo
            // 
            this.replayInfo.BackColor = System.Drawing.SystemColors.Window;
            this.replayInfo.Location = new System.Drawing.Point(165, 317);
            this.replayInfo.Multiline = true;
            this.replayInfo.Name = "replayInfo";
            this.replayInfo.ReadOnly = true;
            this.replayInfo.Size = new System.Drawing.Size(248, 123);
            this.replayInfo.TabIndex = 7;
            this.replayInfo.Text = "No replay selected...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CoH2ReplayTools.Properties.Resources.header;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(165, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 52);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // oneFaction
            // 
            this.oneFaction.HeaderText = "";
            this.oneFaction.Name = "oneFaction";
            this.oneFaction.ReadOnly = true;
            this.oneFaction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oneFaction.Width = 32;
            // 
            // oneName
            // 
            this.oneName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oneName.HeaderText = "Name";
            this.oneName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.oneName.Name = "oneName";
            this.oneName.ReadOnly = true;
            this.oneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // oneCPM
            // 
            this.oneCPM.HeaderText = "CPM";
            this.oneCPM.Name = "oneCPM";
            this.oneCPM.ReadOnly = true;
            this.oneCPM.Width = 50;
            // 
            // oneSteamID
            // 
            this.oneSteamID.HeaderText = "SteamID";
            this.oneSteamID.Name = "oneSteamID";
            this.oneSteamID.ReadOnly = true;
            this.oneSteamID.Visible = false;
            // 
            // twoFaction
            // 
            this.twoFaction.HeaderText = "";
            this.twoFaction.Name = "twoFaction";
            this.twoFaction.ReadOnly = true;
            this.twoFaction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.twoFaction.Width = 32;
            // 
            // twoName
            // 
            this.twoName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.twoName.HeaderText = "Name";
            this.twoName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.twoName.Name = "twoName";
            this.twoName.ReadOnly = true;
            this.twoName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // twoCPM
            // 
            this.twoCPM.HeaderText = "CPM";
            this.twoCPM.Name = "twoCPM";
            this.twoCPM.ReadOnly = true;
            this.twoCPM.Width = 50;
            // 
            // twoSteamID
            // 
            this.twoSteamID.HeaderText = "SteamID";
            this.twoSteamID.Name = "twoSteamID";
            this.twoSteamID.ReadOnly = true;
            this.twoSteamID.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.replayInfo);
            this.Controls.Add(this.gridTeam2);
            this.Controls.Add(this.gridTeam1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDirectory);
            this.Controls.Add(this.buttonReplay);
            this.Controls.Add(this.listReplays);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "CoH2 Replay Tools 0.1b";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ListBox listReplays;
        private System.Windows.Forms.Button buttonReplay;
        private System.Windows.Forms.Button buttonDirectory;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView gridTeam1;
        private System.Windows.Forms.DataGridView gridTeam2;
        private System.Windows.Forms.TextBox replayInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn oneFaction;
        private System.Windows.Forms.DataGridViewLinkColumn oneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneCPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneSteamID;
        private System.Windows.Forms.DataGridViewImageColumn twoFaction;
        private System.Windows.Forms.DataGridViewLinkColumn twoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn twoCPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn twoSteamID;
        private System.Windows.Forms.ToolTip tooltipPlaybackDir;
    }
}

