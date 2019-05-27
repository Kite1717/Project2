using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class HotelFactory
    {

        /// <summary>
        /// the desired hotel-type object produces
        /// </summary>
        /// <param name="hotelType"> name of hotel</param>
        /// <param name="city"> number of room</param>
        /// <returns>gives the desired hotel</returns>

        public static Hotel GetHotel(string hotelType, string city)
        {

            switch (hotelType)
            {

                case "Hostel":
                    {
                        return new Hostel(city);

                    }

                case "BoutiqueHotel":
                    {
                        return new BoutiqueHotel(city);

                    }
                case "AllInHotel":
                    {
                        return new AllInHotel(city);

                    }
                case "HolidayVillage":
                    {
                        return new HolidayVillage(city);

                    }
                case "UltraLuxuryHotel":
                    {
                        return new UltraLuxuryHotel(city);

                    }
            
                default:
                    {
                        if (hotelType != null)
                            Logger.addLog(hotelType, DateTime.Now.ToString("MM/dd/yyyy") +
                                "  ArgumentException :  status => Method , class => HotelFactory , name => GetHotel , value => " + hotelType);

                        else
                            Logger.addLog("hotelType(NULL)", DateTime.Now.ToString("MM/dd/yyyy") +
                            "  ArgumentNullException :  status => Method , class => HotelFactory , name => GetHotel , value => NULL");

                        throw new ArgumentException();

                    }




            }



        }
    }
}
