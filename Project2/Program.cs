using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hostel = new Hostel("canakkale");
            Hotel a = new BoutiqueHotel("canakkale");
            Hotel B = new AllInHotel("canakkale");
            Hotel ASD = new HolidayVillage("canakkale");
            Hotel ASDASD = new UltraLuxuryHotel("canakkale");
        }
    }
}
