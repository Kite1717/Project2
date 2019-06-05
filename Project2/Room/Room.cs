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

        protected Room(int no, List<string> roomContents, Dictionary<User, DateTime> calendar, List<double> prices)
        {
            this.no = no;
            this.roomContents = roomContents;
            this.calendar = calendar;
            this.prices = prices;
        }
        protected abstract bool makeReservation(User user,DateTime start , int count);
        protected abstract bool deleteReservation(User user);


    }
}
