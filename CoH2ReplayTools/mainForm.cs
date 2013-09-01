using CoH2ReplayTools.Exceptions;
using CoH2ReplayTools.Parser;
using CoH2ReplayTools.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoH2ReplayTools
{
    public partial class mainForm : Form
    {
        FolderBrowserDialog dirPick;
        string[] replays;
        int currentSelectedIndex;
        public mainForm()
        {
            InitializeComponent();
            if (!((string)Settings.Default["PlaybackDir"] == ""))
                UpdateReplaysList();
        }

        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            dirPick = new FolderBrowserDialog();
            dirPick.Description = "Select your playback folder.";
            dirPick.RootFolder = Environment.SpecialFolder.Personal;
            dirPick.ShowNewFolderButton = false;

            if (dirPick.ShowDialog() == DialogResult.OK)
            {
                Settings.Default["PlaybackDir"] = dirPick.SelectedPath;
                Settings.Default.Save();
                UpdateReplaysList();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if ((string)Settings.Default["PlaybackDir"] == "")
                MessageBox.Show("Select your playback folder first!");
            else
                UpdateReplaysList();
        }

        private void UpdateReplaysList()
        {
            replays = Directory.GetFiles(@"" + (string)Settings.Default["PlaybackDir"], "*.rec");
            ListBox.ObjectCollection listReps = listReplays.Items;
            listReps.Clear();
            foreach (string rep in replays)
            {
                ReplayStream replay = new ReplayStream(rep);
                if (replay.readUInt32() != 0)
                    listReps.Add(Path.GetFileNameWithoutExtension(rep));
                replay.close();
            }
        }

        private void listReplays_SelectedIndexChanged(object sender, EventArgs e)
        {
            string replayName = (string)listReplays.SelectedItem;
            if (!replayName.Equals("Set playback directory"))
            {
                try
                {
                    ReplayParser replayFile = new ReplayParser((string)Settings.Default["PlaybackDir"] + "\\" + replayName + ".rec");
                    Replay replay = replayFile.Parse();

                    TimeSpan duration = new TimeSpan(0, 0, replay.Duration / 8);

                    replayInfo.Clear();
                    replayInfo.AppendText("Name: " + replayName + Environment.NewLine);
                    replayInfo.AppendText("Version: 3.0.0." + replay.Version + Environment.NewLine);
                    replayInfo.AppendText("Map: " + replay.MapFile + Environment.NewLine);
                    replayInfo.AppendText("Length: " + string.Format("{0:0}:{1:00}:{2:00}", duration.Hours, duration.Minutes, duration.Seconds) + Environment.NewLine);
                    replayInfo.AppendText("Date: " + replay.Date + Environment.NewLine);
                    replayInfo.AppendText("Win Condition: " + replay.WinCondition);

                    gridTeam1.Rows.Clear();
                    gridTeam2.Rows.Clear();

                    ResourceManager resources = new ResourceManager("CoH2ReplayTools.Properties.Resources", typeof(mainForm).Assembly);

                    foreach (Player player in replay.Players)
                    {
                        if (player.TeamID == 0)
                        {
                            gridTeam1.Rows.Add(resources.GetObject("_" + player.FactionID) as Image, player.Name, "--", player.SteamID);
                        }
                        else
                        {
                            gridTeam2.Rows.Add(resources.GetObject("_" + player.FactionID) as Image, player.Name, "--", player.SteamID);
                        }
                    }
                }
                catch (InvalidVersionException ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void gridTeam1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridTeam1.CurrentCell.ColumnIndex == 1)
            {
                Process.Start("http://www.coh2.org/ladders/playercard/steamid/" + gridTeam1.CurrentRow.Cells[3].Value);   
            }
        }

        private void gridTeam2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridTeam2.CurrentCell.ColumnIndex == 1)
            {
                Process.Start("http://www.coh2.org/ladders/playercard/steamid/" + gridTeam2.CurrentRow.Cells[3].Value);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
