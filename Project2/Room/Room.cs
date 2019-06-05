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
        protected Dictionary<DateTime,User> calendar { get; set; }
        protected List<double> prices { get; set; }

        protected Room(int no, List<string> roomContents, Dictionary<DateTime, User> calendar, List<double> prices)
        {
            this.no = no;
            this.roomContents = roomContents;
            this.calendar = calendar;
            this.prices = prices;
        }
        protected abstract bool makeReservation(User user,DateTime start , int count);
        protected abstract bool deleteReservation(User user);

        public override string ToString()
        {
            int k = 0;
            string superString = "\nNo :" + no + "Status : " + this.GetType().Name +  "\nRoomContents\n";
            foreach (string i in roomContents) superString += i + "\n";
            superString += "\n----Calendar-------\n";
            foreach (DateTime i in calendar.Keys)
            {
                superString += i.ToString("dd/MM/yyyy") + "   " + prices[k] + "\n" ;
                k++;
            }
            superString += "\n---------------------------------------\n";
            return superString;

            
        } 
    }
}
