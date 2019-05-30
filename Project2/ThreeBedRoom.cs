using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class ThreeBedRoom : Room
    {
        public ThreeBedRoom(int no,int star) : base(no,star) { }
        protected override void addPrice(int hotelStar)
        {
            throw new NotImplementedException();
        }

        protected override void addRoomContents()
        {
            throw new NotImplementedException();
        }

        protected override void createCalendar()
        {
            throw new NotImplementedException();
        }

        protected override bool deleteReservation(User user)
        {
            throw new NotImplementedException();
        }

        protected override bool makeReservation(User user, DateTime start, int count)
        {
            throw new NotImplementedException();
        }
    }
}
