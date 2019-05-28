using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class App
    {
       private List<Hotel> hotels;
       private List<User> users;
        private Administration admin;

        public App()
        {

            if (!continueApp())
                startDemo();
            else loginScreen();
        }

        /// <summary>
        /// serialization process
        /// </summary>
        /// <returns>xml file empty control</returns>
        private bool  continueApp()
        {
            return false;
        }
        /// <summary>
        /// auto adds hotels , admin and start sing up/in screen
        /// default 30 otel 
        /// </summary>
        public void startDemo()
        {
            Random random = new Random();
            int k;
            string type = null;
            string[] data = { "ISTANBUL", "CANAKKALE", "IZMIR", "KOCAELI", "ANKARA", "ANTALYA", "MUGLA", "VAN", "KARS", "ESKISEHIR" };
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    k = random.Next(1, 6);
                    type = null;
                
                    switch (k)
                    {
                        case 1:
                            {
                                type = "Hostel";
                                break;

                            }
                        case 2:
                            {
                                type = "BoutiqueHotel";
                                break;

                            }
                        case 3:
                            {
                                type = "AllInHotel";
                                break;

                            }
                        case 4:
                            {
                                type = "HolidayVillage";
                                break;

                            }
                        case 5:
                            {
                                type = "UltraLuxuryHotel";
                                break;

                            }
                    }
                    hotels.Add(HotelFactory.GetHotel(type, data[i]));


                
                }
              

            }
            for (int i = 0; i < hotels.Count; i++)
            {
                hotels
            }


           

            //add hotels
            loginScreen();
        }

        private void addRoom(Hotel hotel)
        {
            switch(hotel.star)
            {
                case 1:
                    {                       
                        int num = 100;
                        for (int i = 0; i < hotel.roomCapacity / 2; i++)
                        {
                            num++;
                           hotel. rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
                        }
                        num = 200;
                        for (int i = 0; i < hotel.roomCapacity - hotel.roomCapacity / 2; i++)
                        {
                            num++;
                           hotel.rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
                        }
                        //wrong room name
                        try
                        {
                            hotel.rooms.Add(RoomFactory.GetRoom("Tsadasm", 518));
                        }
                        catch (ArgumentException e)
                        {

                        }

                        break;

                    }
                case 2:
                    {
                      
                        int num = 100;
                        for (int i = 0; i < hotel.roomCapacity / 3; i++)
                        {
                            num++;
                           hotel.rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
                        }
                        num = 200;
                        for (int i = 0; i < hotel.roomCapacity / 3; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
                        }

                        num = 300;
                        for (int i = 0; i < hotel.roomCapacity - ((hotel.roomCapacity / 3) * 2); i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("TwinRoom", num));
                        }

                        //null room name
                        try
                        {
                            hotel.rooms.Add(RoomFactory.GetRoom(null, 312));
                        }
                        catch (ArgumentException e)
                        {

                        }
                        break;

                    }
                case 3:
                    {
                        int num = 100;
                        for (int i = 0; i < hotel.roomCapacity / 4; i++)
                        {
                            num++;
                           hotel.rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
                        }
                        num = 200;
                        for (int i = 0; i < hotel.roomCapacity / 4; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
                        }

                        num = 300;
                        for (int i = 0; i < hotel.roomCapacity / 4; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("TwinRoom", num));
                        }


                        num = 400;
                        for (int i = 0; i < hotel.roomCapacity - ((hotel.roomCapacity / 4) * 3); i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("ThreeBedRoom", num));
                        }

                        //wrong room name
                        try
                        {
                            hotel.rooms.Add(RoomFactory.GetRoom("adsadasda", 426));
                        }
                        catch (ArgumentException e)
                        {

                        }
                        break;

                    }
                case 4:
                    {
                        int num = 100;
                        for (int i = 0; i < hotel.roomCapacity / 5; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
                        }
                        num = 200;
                        for (int i = 0; i < hotel.roomCapacity / 5; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
                        }

                        num = 300;
                        for (int i = 0; i < hotel.roomCapacity / 5; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("TwinRoom", num));
                        }


                        num = 400;
                        for (int i = 0; i < hotel.roomCapacity / 5; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("ThreeBedRoom", num));
                        }

                        num = 500;
                        for (int i = 0; i < hotel.roomCapacity - ((hotel.roomCapacity / 5) * 4); i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("FamilyRoom", num));
                        }

                        //null room name
                        try
                        {
                            hotel.rooms.Add(RoomFactory.GetRoom(null, 718));
                        }
                        catch (ArgumentException e)
                        {

                        }
                        break;

                    }
                case 5:
                    {
                        int num = 100;
                        for (int i = 0; i < hotel.roomCapacity / 6; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("SingleBedRoom", num));
                        }
                        num = 200;
                        for (int i = 0; i < hotel.roomCapacity / 6; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("TwoBedRoom", num));
                        }

                        num = 300;
                        for (int i = 0; i < hotel.roomCapacity / 6; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("TwinRoom", num));
                        }


                        num = 400;
                        for (int i = 0; i < hotel.roomCapacity / 6; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("ThreeBedRoom", num));
                        }

                        num = 500;
                        for (int i = 0; i < hotel.roomCapacity / 6; i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("FamilyRoom", num));
                        }

                        num = 600;
                        for (int i = 0; i < hotel.roomCapacity - ((hotel.roomCapacity / 6) * 5); i++)
                        {
                            num++;
                            hotel.rooms.Add(RoomFactory.GetRoom("KingRoom", num));
                        }


                        //wrong room name
                        try
                        {
                            hotel.rooms.Add(RoomFactory.GetRoom("mustafa", 333));
                        }
                        catch (ArgumentException e)
                        {

                        }

                        break;

                    }
            }

        }

        /// <summary>
        ///  registration and entry procedures
        /// </summary>
        public void loginScreen()
        {
            //register process

            // if (admin) startModule(new AdminModule(hotels, users, adminId, adminPassword));
            // if (user) startModule(new UserModule(hotels, users, userId, userPassword));

          

        }
        /// <summary>
        /// user / administrator operations
        /// </summary>
        /// <param name="module">type of module</param>

        public void startModule(Module module)
        {
            /*bool quit = false;
           while (!quit)
           {
               switch()
               // some process.

           }
           */
            exit();
        }
        //program information will be saved and output
        // use serialization
        public void exit()
        {

            /* HotelAggregate aggregate = new HotelAggregate();
             
             foreach (Hotel item in hotels) aggregate.Add(item);

              IIterator iterator = aggregate.CreateIterator();

              while (iterator.HasItem())
              {
                  superString += iterator.CurrentItem().ToString();
                  iterator.NextItem();
              } */

        }


    }
}
