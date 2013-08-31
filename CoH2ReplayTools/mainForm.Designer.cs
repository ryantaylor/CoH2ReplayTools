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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listReplays = new System.Windows.Forms.ListBox();
            this.buttonReplay = new System.Windows.Forms.Button();
            this.buttonDirectory = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sovietFaction = new System.Windows.Forms.DataGridViewImageColumn();
            this.sovietName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.sovietCPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ostheerFaction = new System.Windows.Forms.DataGridViewImageColumn();
            this.ostheerName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ostheerCPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // listReplays
            // 
            this.listReplays.FormattingEnabled = true;
            this.listReplays.HorizontalScrollbar = true;
            this.listReplays.Items.AddRange(new object[] {
            "Set playback directory"});
            this.listReplays.Location = new System.Drawing.Point(12, 85);
            this.listReplays.Name = "listReplays";
            this.listReplays.Size = new System.Drawing.Size(136, 342);
            this.listReplays.TabIndex = 1;
            // 
            // buttonReplay
            // 
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
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sovietFaction,
            this.sovietName,
            this.sovietCPM});
            this.dataGridView1.Location = new System.Drawing.Point(165, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(248, 100);
            this.dataGridView1.TabIndex = 5;
            // 
            // sovietFaction
            // 
            this.sovietFaction.HeaderText = "";
            this.sovietFaction.Name = "sovietFaction";
            this.sovietFaction.ReadOnly = true;
            this.sovietFaction.Width = 32;
            // 
            // sovietName
            // 
            this.sovietName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sovietName.HeaderText = "Name";
            this.sovietName.Name = "sovietName";
            this.sovietName.ReadOnly = true;
            // 
            // sovietCPM
            // 
            this.sovietCPM.HeaderText = "CPM";
            this.sovietCPM.Name = "sovietCPM";
            this.sovietCPM.ReadOnly = true;
            this.sovietCPM.Width = 50;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ostheerFaction,
            this.ostheerName,
            this.ostheerCPM});
            this.dataGridView2.Location = new System.Drawing.Point(165, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(248, 100);
            this.dataGridView2.TabIndex = 6;
            // 
            // ostheerFaction
            // 
            this.ostheerFaction.HeaderText = "";
            this.ostheerFaction.Name = "ostheerFaction";
            this.ostheerFaction.ReadOnly = true;
            this.ostheerFaction.Width = 32;
            // 
            // ostheerName
            // 
            this.ostheerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ostheerName.HeaderText = "Name";
            this.ostheerName.Name = "ostheerName";
            this.ostheerName.ReadOnly = true;
            // 
            // ostheerCPM
            // 
            this.ostheerCPM.HeaderText = "CPM";
            this.ostheerCPM.Name = "ostheerCPM";
            this.ostheerCPM.ReadOnly = true;
            this.ostheerCPM.Width = 50;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(165, 297);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(248, 130);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "No replay selected...";
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDirectory);
            this.Controls.Add(this.buttonReplay);
            this.Controls.Add(this.listReplays);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "CoH2 Replay Tools 0.1b";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn sovietFaction;
        private System.Windows.Forms.DataGridViewLinkColumn sovietName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sovietCPM;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewImageColumn ostheerFaction;
        private System.Windows.Forms.DataGridViewLinkColumn ostheerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ostheerCPM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

