using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// 2 stars hotel
    /// </summary>
    class BoutiqueHotel : Hotel
    {
        public BoutiqueHotel(string city) : base(city,2)
        {
        }

        public override bool addRoom()
        {
            throw new NotImplementedException();
        }
    }
}
