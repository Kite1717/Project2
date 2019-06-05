using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class AdminModule :Module
    {
        
       

        public AdminModule(ref List<Hotel> hotels, ref List<User> users , string adminId , string adminPassword)
        {
            if (adminId.Equals("Kite") && adminPassword.Equals("2737600"))
            {
                login = true;
                base.hotels = hotels;
                base.users = users;
                
            }
            else
            {
                login = false;
                //TODO add exception
                Logger.addLog(null, null);
                throw new ArgumentException();
            }

        }
       
        public bool addHotel(string cityName)
        {
            return true;
        }

        public bool deleteHotel(string cityName)
        {
            return true;
        }


        public bool addRoom(string cityName,string hotelType)
        {
            return true;
        }

        public bool deleteRoom(string cityName, string hotelType)
        {
            return true;
        }

        public bool summaryInfo(DateTime start , DateTime end)
        {
          
            return true;
        }






    }
}
