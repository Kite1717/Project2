using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class TwinRoom : Room
    {
        public TwinRoom(int no, List<string> roomContents, Dictionary<DateTime, User> calendar, List<double> prices)
            : base(no, roomContents, calendar, prices) { }


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
