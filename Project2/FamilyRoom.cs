using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class FamilyRoom : Room
    {
        public FamilyRoom(int no) : base(no) { }
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
