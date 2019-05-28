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
        public int star { get; }
        public List<Room> rooms { get; }
        public int roomCapacity { get; }
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
            Random random = new Random();
            switch(star)
            {
                case 1:
                    {
                        roomCapacity = random.Next(7, 11);
                        break;
                    }
                case 2:
                    {
                        roomCapacity = random.Next(10, 16);
                        break;
                    }
                case 3:
                    {
                        roomCapacity = random.Next(15, 21);
                        break;
                    }
                case 4:
                    {
                        roomCapacity = random.Next(20, 26);
                        break;
                    }
                case 5:
                    {
                        roomCapacity = random.Next(25, 31);
                        break;
                    }
                           
            }

        }

       

        /// <summary>
        /// for saving information when closing the application
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return null;
        }
    }
}
