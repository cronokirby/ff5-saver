using System;

namespace FF5Saver.Data
{   
    /// <summary>
    /// Represents a single character loaded from a save file.
    /// </summary>
    public class Character
    {   
        enum Jobs
        { Knight, Monk, Thief, Dragoon, Ninja,
          Samurai, Berserker, Hunter, MysticKnight,
          WhiteMage, BlackMage, TimeMage, Summoner,
          BlueMage, RedMage, Mediator, Chemist,
          GeoMancer, Bard, Dancer, Mimic, Freelancer
        }

        public Jobs Job { get; set; }

        public byte Level { get; set; }

        public Character(byte[] characterData)
        {
            Job = (Jobs)characterData[1];
            Level = characterData[2];

        }
    }
}

