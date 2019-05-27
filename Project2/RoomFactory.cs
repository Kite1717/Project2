using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class RoomFactory
    {

        public static Room GetRoom(string roomType, int roomNo)
        {

            switch (roomType)
            {

                case "KingRoom":
                    {
                        return new KingRoom(roomNo);

                    }

                case "FamilyRoom":
                    {
                        return new FamilyRoom(roomNo);

                    }
                case "SingleBedRoom":
                    {
                        return new SingleBedRoom(roomNo);

                    }
                case "ThreeBedRoom":
                    {
                        return new ThreeBedRoom(roomNo);

                    }
                case "TwinRoom":
                    {
                        return new TwinRoom(roomNo);

                    }
                case "TwoBedRoom":
                    {
                        return new TwoBedRoom(roomNo);

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
