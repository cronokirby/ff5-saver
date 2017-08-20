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

        public Character(ByteReader characterData)
        {
            Job = (Jobs)characterData.Byte();
            Level = characterData.Byte();
            Exp = characterData.Triple();
            CurrentHP = characterData.Word();
            MaxHP = characterData.Word();
            CurrentMP = characterData.Word();
            MaxMP = characterData.Word();
        }
    }
}

