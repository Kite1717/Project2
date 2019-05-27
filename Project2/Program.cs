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
            Logger.writeToFile();
            string add = null;
            Console.WriteLine(new Exception().GetType().Name.ToString());
            Logger.readToFile();
        }
    }
}
