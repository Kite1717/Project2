using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// other hotels will consist of this hotel class
    /// </summary>
    abstract class Hotel
    {
        protected string city { get; }
        protected int star { get; }
        protected List<Room> rooms;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="city">the city where</param>
        /// <param name="star">the number of stars that you have</param>
        public Hotel(string city, int star)
        {
            this.city = city;
            this.star = star;
            this.rooms = new List<Room>();

        }

        /// <summary>
        ///  according to the structure of the hotel adds to the room
        /// </summary>
        /// <returns>to be successful control</returns>
        public abstract bool addRoom();
        





    }
}
