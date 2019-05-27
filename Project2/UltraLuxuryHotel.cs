using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// 5 stars hotel
    /// </summary>
    class UltraLuxuryHotel : Hotel
    {
        public int roomCapacity { get; } // 25 -30
        public UltraLuxuryHotel(string city) : base(city,5)
        {
            Random random = new Random();
            roomCapacity = random.Next(25, 30);
            addRoom();
        }

        /// <summary>
        /// has all room types 
        /// </summary>
        /// <returns>once for inclusion</returns>
        public override bool addRoom()
        {
            if (rooms.Count != 0) return false;
            int num = 100;
            for (int i = 0; i < roomCapacity / 6; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
            }
            num = 200;
            for (int i = 0; i < roomCapacity / 6; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
            }

            num = 300;
            for (int i = 0; i < roomCapacity / 6; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("TwinRoom", num));
            }


            num = 400;
            for (int i = 0; i < roomCapacity / 6; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("ThreeBedRoom", num));
            }
            
            num = 500;
            for (int i = 0; i < roomCapacity / 6; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("FamilyRoom", num));
            }

            num = 600;
            for (int i = 0; i < roomCapacity - ((roomCapacity / 6) * 5); i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("KingRoom", num));
            }


            //wrong room name
            try
            {
                rooms.Add(RoomFactory.GetRoom("mustafa", 333));
            }
            catch (ArgumentException e)
            {

            }
          
            return true;
        }
    }
}
