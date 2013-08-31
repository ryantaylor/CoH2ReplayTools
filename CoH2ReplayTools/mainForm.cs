using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoH2ReplayTools
{
    public partial class mainForm : Form
    {
        FolderBrowserDialog dirPick;
        string[] replays;
        string playbackDirectory = "";
        public mainForm()
        {
            InitializeComponent();
        }

        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            dirPick = new FolderBrowserDialog();
            dirPick.Description = "Select your playback folder.";
            dirPick.RootFolder = Environment.SpecialFolder.Personal;
            dirPick.ShowNewFolderButton = false;

            if (dirPick.ShowDialog() == DialogResult.OK)
            {
                playbackDirectory = dirPick.SelectedPath;
                UpdateReplaysList();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (playbackDirectory == "")
                MessageBox.Show("Select your playback folder first!");
            else
                UpdateReplaysList();
        }

        private void UpdateReplaysList()
        {
            replays = Directory.GetFiles(@"" + playbackDirectory, "*.rec");
            ListBox.ObjectCollection listReps = listReplays.Items;
            listReps.Clear();
            foreach (string rep in replays)
            {
                listReps.Add(Path.GetFileNameWithoutExtension(rep));
            }
        }
    }
}
