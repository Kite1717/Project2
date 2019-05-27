using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// 4 stars hotel
    /// </summary>
    class HolidayVillage : Hotel
    {
        private int roomCapacity; // range 20 - 25
        public HolidayVillage(string city) : base(city, 4)
        {
            Random random = new Random();
            roomCapacity = random.Next(20, 26);
            addRoom();
        }

        /// <summary>
        ///  only single bed room ,  two bed room , twin room , three bed room  and family room
        ///  in the  Holiday Village includes 
        /// </summary>
        /// <returns>once for inclusion</returns>
        public override bool addRoom()
        {
            if (rooms.Count != 0) return false;
            int num = 100;
            for (int i = 0; i < roomCapacity / 5; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
            }
            num = 200;
            for (int i = 0; i < roomCapacity / 5; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
            }

            num = 300;
            for (int i = 0; i < roomCapacity / 5; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("TwinRoom", num));
            }

           
            num = 400;
            for (int i = 0; i < roomCapacity / 5 ; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("ThreeBedRoom", num));
            }

            num = 500;
            for (int i = 0; i < roomCapacity - ((roomCapacity / 5) * 4); i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("FamilyRoom", num));
            }

            //null room name
            try
            {
                rooms.Add(RoomFactory.GetRoom(null, 718));
            }
            catch (ArgumentException e)
            {

            }
           
            return true;
        }
    }
}
