using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    #region Abstract_Factory 
    //Ref Link : https://dzone.com/articles/factory-method-design-pattern
    class RoomFactory
    {
     private static   Random random = new Random(DateTime.Now.Millisecond);
        /// <summary>
        /// the desired room-type object produces
        /// </summary>
        /// <param name="roomType"> name of room</param>
        /// <param name="roomNo"> number of room</param>
        /// <returns> gives the desired room</returns>

        public static Room GetRoom(string roomType, int roomNo,int star)
        {
            List<double> prices = new List<double>();
            Dictionary<DateTime, User> calendar = new Dictionary<DateTime, User>();
            List<string> roomContents = new List<string>();

            addDefaultContent(ref roomContents, ref calendar, ref prices, star, roomType);
            


            switch (roomType)
            {
                

                case "KingRoom":
                    {
                        return new KingRoom(roomNo,roomContents,calendar,prices);

                    }

                case "FamilyRoom":
                    {
                        return new FamilyRoom(roomNo, roomContents, calendar, prices);

                    }
                case "SingleBedRoom":
                    {
                        return new SingleBedRoom(roomNo, roomContents, calendar, prices);

                    }
                case "ThreeBedRoom":
                    {
                        return new ThreeBedRoom(roomNo, roomContents, calendar, prices);
                    }
                case "TwinRoom":
                    {
                        return new TwinRoom(roomNo, roomContents, calendar, prices);

                    }
                case "TwoBedRoom":
                    {
                        return new TwoBedRoom(roomNo, roomContents, calendar, prices);

                    }
                default:
                    {
                        if (roomType != null)
                            Logger.addLog(roomType, DateTime.Now.ToString("MM/dd/yyyy") +
                                "  ArgumentException :  status => Method , class => RoomFactory , name => GetRoom , value => " + roomType);

                        else
                            Logger.addLog("roomType(NULL)", DateTime.Now.ToString("MM/dd/yyyy") +
                            "  ArgumentNullException :  status => Method , class => RoomFactory , name => GetRoom , value => NULL");

                        throw new ArgumentException();

                    }
            }

          
        }

        private static void addDefaultContent(ref List<string> roomContents,ref Dictionary<DateTime,User> calendar , ref List<double> prices,int star , string roomType)
        {
            int min=0, max=0;
            
            switch (roomType)
            {


                case "KingRoom":
                    {
                        min = 600;
                        max = 700;
                        roomContents.Add("Free Wifi");
                        roomContents.Add("mini bar");
                        roomContents.Add("jacuzzi");
                        roomContents.Add("TV");
                        roomContents.Add("Balcony");
                        roomContents.Add("Tea, coffee, water, espresso-machine");
                        roomContents.Add("Gold plated toilet");
                        break;

                    }

                case "FamilyRoom":
                    {
                        min = 470;
                        max = 570;
                        roomContents.Add("Free Wifi");
                        roomContents.Add("Crib");
                        roomContents.Add("TV");
                        roomContents.Add("Balcony");
                        roomContents.Add("Climate");
                      
                        break;
                    }
                case "SingleBedRoom":
                    {

                        min = 60;
                        max = 110;
                        roomContents.Add("Free Wifi");
                        roomContents.Add("TV");
                        break;

                    }
                case "ThreeBedRoom":
                    {
                        roomContents.Add("TV");
                        roomContents.Add("Free Wifi");
                        roomContents.Add("Tea, coffee, water, espresso-machine");
                        roomContents.Add("Climate");
                        min = 350;
                        max = 450;
                        break;

                    }
                case "TwinRoom":
                    {
                        roomContents.Add("TV");
                        roomContents.Add("Free Wifi");
                        roomContents.Add("Climate");
                        min = 220;
                        max = 320;
                        break;

                    }
                case "TwoBedRoom":
                    {
                        roomContents.Add("TV");
                        roomContents.Add("Free Wifi");
                        roomContents.Add("Climate");
                        min = 140;
                        max = 210;
                        break;

                    }

            }

            
            int pr;
            // default calendar and price
            var day = DateTime.Now;
           
            for (int i = 0; i < 365; i++)
            {

                calendar.Add(day, new User("", "", "", "", -1));
                day = day.AddDays(1);
                pr = random.Next((min * star), (max * star) + 1);
                prices.Add(pr);

            }
            pr = random.Next(1, 5);
            if (pr == 1) roomContents.Add("Pool view");
            else if (pr == 2) roomContents.Add("Forest view");
            else if (pr == 3) roomContents.Add("Sea view");
            else roomContents.Add("Lake view");





        }
    }
}
#endregion