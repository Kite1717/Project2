using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// 3 stars hotel
    /// </summary>
    class AllInHotel : Hotel
    {
        public int roomCapacity { get; }//range 15-20
        public AllInHotel(string city) : base(city,3)
        {
            Random random = new Random();
            roomCapacity = random.Next(15, 21);
            addRoom();
        }

        /// <summary>
        /// only single bed room ,  two bed room , twin room and three bed room in the  All In Hotel includes 
        /// </summary>
        /// <returns>once for inclusion</returns>
        public override bool addRoom()
        {
            if (rooms.Count != 0) return false;
            int num = 100;
            for (int i = 0; i < roomCapacity / 4; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
            }
            num = 200;
            for (int i = 0; i < roomCapacity / 4; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
            }

            num = 300;
            for (int i = 0; i < roomCapacity / 4; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("TwinRoom", num));
            }


            num = 400;
            for (int i = 0; i < roomCapacity - ((roomCapacity / 4) * 3); i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("ThreeBedRoom", num));
            }

            //wrong room name
            try
            {
                rooms.Add(RoomFactory.GetRoom("adsadasda", 426));
            }
            catch (ArgumentException e)
            {

            }
           


            return true;
        }
    }
}
