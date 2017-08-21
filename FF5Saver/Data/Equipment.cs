using System;

namespace FF5Saver.Data
{   
    /// <summary>
    /// Represents a full set of equipment for a Character.
    /// </summary>
    public class Equipment
    {  
        public Items Helmet { get; set; }

        public Items Armor { get; set; }

        public Items Relic { get; set; }

        public Items RightHand { get; set; }

        public Items LeftHand { get; set; }


        public Equipment(ByteReader data)
        {
            Helmet = (Items)data.Byte();
            Armor = (Items)data.Byte();
            Relic = (Items)data.Byte();
            data.Skip(2);
            RightHand = (Items)data.Byte();
            LeftHand = (Items)data.Byte();
        }
    }
}

