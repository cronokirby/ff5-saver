using System;

namespace FF5Saver.Data
{   
    /// <summary>
    /// Represents a single character loaded from a save file.
    /// </summary>
    public class Character
    {   
        public enum Jobs
        { Knight, Monk, Thief, Dragoon, Ninja,
          Samurai, Berserker, Hunter, MysticKnight,
          WhiteMage, BlackMage, TimeMage, Summoner,
          BlueMage, RedMage, Mediator, Chemist,
          GeoMancer, Bard, Dancer, Mimic, Freelancer
        }

        public Jobs Job { get; set; }

        public byte Level { get; set; }

        public uint Exp { get; set; }

        public ushort CurrentHP { get; set; }

        public ushort MaxHP { get; set; }

        public ushort CurrentMP { get; set; }

        public ushort MaxMP { get; set; }

 

        public Character(byte[] characterData)
        {
            Job = (Jobs)characterData[1];
            Level = characterData[2];
            Exp = ByteHelper.GetTriple(characterData, 3);
            CurrentHP = ByteHelper.GetWord(characterData, 6);
            MaxHP = ByteHelper.GetWord(characterData, 8);
            CurrentMP = ByteHelper.GetWord(characterData, 0x0A);
            MaxMP = ByteHelper.GetWord(characterData, 0x0C);
        }
    }
}

