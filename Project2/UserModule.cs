using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class UserModule : Module
    {
        private int userLocation;
        public UserModule( ref List<Hotel> hotels, ref List<User> users, string userId, string userPassword)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if(users[i].ID.Equals(userId) && users[i].Password.Equals(userPassword))
                {
                    userLocation = i;
                    login = true;
                    break;
                }
            }

            if (login)
            {
                base.hotels = hotels;
                base.users = users;
            }
            else
            {
                //TODO add expection
                Logger.addLog(null, null);
                throw new ArgumentException();
            }
            
        }

        public bool makeReservation(string city , int star ,int MinPayment , int MaxPayment , DateTime start , DateTime end , List<string> roomFeatures , string roomType)
        {
            //if(login) 
            //....
            //.....
            return true;
        }
        public bool deleteReservation()
        {
            //if(login) 
            //....
            //.....
            return true;
        }

        public void displayReservationInfo()
        {
            //if(login) 
            //....
            //.....
        }
        public bool updatePersonalInfo(int choice)
        {
            //if(login) 
            //....
            //.....
            switch (choice)
            {

            }
            return true;
        }



    }
}
