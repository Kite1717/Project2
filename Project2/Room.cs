using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
   abstract class Room 
    {
       
        protected int no { get; }
        protected List<string> roomContents { get;}
        protected Dictionary<User,DateTime> calendar { get; set; }
        protected List<double> prices { get; set; }
        

        protected Room(int no,int star)
        {
            this.no = no;
            calendar = new Dictionary<User, DateTime>();
            prices = new List<double>();
            roomContents = new List<string>();
        }
        protected abstract void createCalendar();
        protected abstract void addRoomContents();
        protected abstract void addPrice(int hotelStar);

        protected abstract bool makeReservation(User user,DateTime start , int count);
        protected abstract bool deleteReservation(User user);


    }
}
