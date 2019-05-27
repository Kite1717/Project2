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
        /// </summary>
        public void startDemo()
        {
            //add hotels
            loginScreen();
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
