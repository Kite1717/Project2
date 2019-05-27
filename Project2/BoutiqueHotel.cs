using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// 2 stars hotel
    /// </summary>
    class BoutiqueHotel : Hotel
    {
        public int roomCapacity { get; } // range 10 - 15
        public BoutiqueHotel(string city) : base(city,2)
        {
            Random random = new Random();
            roomCapacity = random.Next(10, 16);
            addRoom();

        }
        /// <summary>
        /// only single bed room ,  two bed room  and twin room in the Boutique Hotel includes
        /// </summary>
        /// <returns>once for inclusion</returns>

        public override bool addRoom()
        {
            if (rooms.Count != 0) return false;
            int num = 100;
            for (int i = 0; i < roomCapacity / 3; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
            }
            num = 200;
            for (int i = 0; i < roomCapacity / 3; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
            }

            num = 300;
            for (int i = 0; i < roomCapacity -  ((roomCapacity / 3) * 2); i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("TwinRoom", num));
            }

            //null room name
            try
            {
                rooms.Add(RoomFactory.GetRoom(null, 312));
            }
            catch (ArgumentException e)
            {

            }
           
            return true;
        }
    }
}
