using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoH2ReplayTools.Parser
{
    class Player
    {
        public string Name { get; set; }
        public UInt64 SteamID { get; set; }
        public uint PlayerID { get; set; }
        public uint FactionID { get; set; }
        public uint TeamID { get; set; }
        public List<uint> CommanderIDs { get; set; }
        public List<string> Bulletins { get; set; }
        public List<uint> BulletinIDs { get; set; }
        public int Commands { get; set; }

        public Player()
        {
            Name = null;
            SteamID = 0;
            PlayerID = 0;
            FactionID = 0;
            TeamID = 0;
            CommanderIDs = new List<uint>();
            Bulletins = new List<string>();
            BulletinIDs = new List<uint>();
            Commands = 0;
        }

        public Player(string name)
        {
            Name = name;
            SteamID = 0;
            PlayerID = 0;
            FactionID = 0;
            TeamID = 0;
            CommanderIDs = new List<uint>();
            Bulletins = new List<string>();
            BulletinIDs = new List<uint>();
            Commands = 0;
        }
    }
}
