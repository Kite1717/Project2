using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// 1 star hotel
    /// </summary>
    class Hostel : Hotel
    {
        private int roomCapacity; // range 7 - 10
        public Hostel(string city) : base(city,1)
        {
            Random random = new Random();
            roomCapacity = random.Next(7, 11);
            addRoom();
        }

        /// <summary>
        /// only single bed room and two bed room in the hostel includes
        /// </summary>
        /// <returns>once for inclusion</returns>
        public override bool addRoom()
        {
            if (rooms.Count != 0) return false;
            int num = 100;
            for (int i = 0; i < roomCapacity/2; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
            }
            num = 200;
            for (int i = 0; i < roomCapacity - roomCapacity/2; i++)
            {
                num++;
                rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
            }
            //wrong room name
            try
            {
                rooms.Add(RoomFactory.GetRoom("Tsadasm", 518));
            }
           catch(ArgumentException e)
            {

            }
            
            return true;
            
        }
    }
}
