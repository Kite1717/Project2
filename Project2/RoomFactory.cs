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
        /// <summary>
        /// the desired room-type object produces
        /// </summary>
        /// <param name="roomType"> name of room</param>
        /// <param name="roomNo"> number of room</param>
        /// <returns> gives the desired room</returns>

        public static Room GetRoom(string roomType, int roomNo,int star)
        {

            switch (roomType)
            {

                case "KingRoom":
                    {
                        return new KingRoom(roomNo,star);

                    }

                case "FamilyRoom":
                    {
                        return new FamilyRoom(roomNo,star);

                    }
                case "SingleBedRoom":
                    {
                        return new SingleBedRoom(roomNo,star);

                    }
                case "ThreeBedRoom":
                    {
                        return new ThreeBedRoom(roomNo,star);

                    }
                case "TwinRoom":
                    {
                        return new TwinRoom(roomNo,star);

                    }
                case "TwoBedRoom":
                    {
                        return new TwoBedRoom(roomNo,star);

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
    }
}
#endregion