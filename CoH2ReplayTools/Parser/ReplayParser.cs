using CoH2ReplayTools.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoH2ReplayTools.Parser
{
    class ReplayParser
    {
        private Replay Replay { get; set; }
        private ReplayStream Stream { get; set; }

        public ReplayParser(string filename)
        {
            Replay = new Replay(filename);
            Stream = Replay.Stream;
        }

        public Replay Parse()
        {
            Stream.skip(2);

            Replay.Version = Stream.readUInt16();
            if (Replay.Version == 0) throw new InvalidVersionException("Replays prior to version 3.0.0.10242 cannot be parsed!");
            Replay.GameType = Stream.readASCIIStr(8);

            string Time = "";
            while (Stream.readUInt16() != 0)
            {
                Stream.skip(-2);
                Time += Stream.readUnicodeStr(1);
            }
            Replay.Date = Time;

            Stream.seek(76);

            parseChunky();
            parseChunky();

            parseData();

            Stream.close();
            return Replay;
        }

        private bool parseChunky()
        {
            if (!(Stream.readASCIIStr(12).Equals("Relic Chunky"))) return false;

            Stream.skip(4);

            if (Stream.readUInt32() != 3) return false;

            Stream.skip(4);
            Stream.skip(Stream.readUInt32() - 28);

            while (parseChunk()) ;

            return true;
        }

        private bool parseChunk()
        {
            string ChunkType = Stream.readASCIIStr(8);
            if (!(ChunkType.Substring(0, 4).Equals("FOLD") || ChunkType.Substring(0, 4).Equals("DATA")))
            {
                Stream.skip(-8);
                return false;
            }

            uint ChunkVersion = Stream.readUInt32();
            uint ChunkLength = Stream.readUInt32();
            uint ChunkNameLength = Stream.readUInt32();

            Stream.skip(8);

            string ChunkName = "";

            if (ChunkNameLength > 0)
                ChunkName = Stream.readASCIIStr(ChunkNameLength);

            long StartPosition = Stream.position;

            if (ChunkType.Substring(0, 4).Equals("FOLD"))
            {
                while (Stream.position < StartPosition + ChunkLength)
                    parseChunk();
            }

            // chunk version: 0x7de
            if (ChunkType.Equals("DATASDSC") && ChunkVersion == 0x7de)
            {
                Stream.skip(16);
                Stream.skip(12 + 2 * Stream.readUInt32());
                
                Replay.ModName = Stream.readASCIIStr();
                Replay.MapFile = Stream.readASCIIStr();

                Stream.skip(16);

                Replay.MapName = Stream.readUnicodeStr();

                Stream.skip(4);

                Replay.MapDescription = Stream.readUnicodeStr();

                Stream.skip(4);

                Replay.MapWidth = Stream.readUInt32();
                Replay.MapHeight = Stream.readUInt32();

                Stream.skip(47);

                if (Stream.readUInt32() > 0)
                {
                    Stream.skip(-4);
                    Replay.Season = Stream.readASCIIStr();
                }
            }

            // chunk version: 0x8
            if (ChunkType.Equals("DATADATA") && ChunkVersion == 0x8)
            {
                Stream.skip(29);

                uint NumPlayers = Stream.readUInt32();

                for (int i = 0; i < NumPlayers; i ++)
                    Replay.Players.Add(parsePlayer());

                Stream.skip(90);

                Replay.WinCondition = Stream.readASCIIStr();
            }

            Stream.seek(StartPosition + ChunkLength);

            return true;
        }

        private Player parsePlayer()
        {
            Stream.skip(1);

            Player player = new Player(Stream.readUnicodeStr());

            player.TeamID = Stream.readUInt32();
            player.FactionID = Stream.readUInt32();

            Stream.skip(41);

            player.SteamID = Stream.readUInt64();

            Stream.skip(4);

            for (int i = 0; i < 3; i++)
                player.CommanderIDs.Add(Stream.readUInt32());

            Stream.skip(4);

            for (int i = 0; i < 3; i++)
            {
                uint bulletinID = Stream.readUInt32();
                if (bulletinID != 0xffffffff)
                    player.BulletinIDs.Add(bulletinID);
            }

            Stream.skip(4);

            uint NumBulletins = Stream.readUInt32();
            for (int i = 0; i < NumBulletins; i++)
            {
                player.Bulletins.Add(Stream.readASCIIStr());
                Stream.skip(4);
            }

            Stream.skip(9);

            return player;
        }

        private void parseData()
        {
            while (parseTick()) ;
        }

        private bool parseTick()
        {
            Stream.skip(4);

            if (Stream.position > Stream.length)
                return false;

            uint TickSize = Stream.readUInt32();

            Stream.skip(TickSize);
            Replay.Duration++;
            return true;

            /*if (TickSize != null)
            {
                Stream.skip(TickSize);
                Replay.Duration++;
                return true;
            }*/

            //return false;
        }
    }
}
