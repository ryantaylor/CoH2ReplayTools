using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoH2ReplayTools.Parser
{
    class Replay
    {
        public ReplayStream Stream { get; }
        public uint Version { get; set; }
        public string GameType { get; set; }
        public string WinCondition { get; set; }
        public string Date { get; set; }
        public string ModName { get; set; }
        public string MapFile { get; set; }
        public string MapName { get; set; }
        public string MapDescription { get; set; }
        public uint MapWidth { get; set; }
        public uint MapHeight { get; set; }
        public string Season { get; set; }
        public uint Duration { get; set; }
        public List<Player> Players { get; set; }
    }
}
