using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    #region Singleton
    // we used lazy initialization
    //Ref Link : https://www.geeksforgeeks.org/singleton-design-pattern/
    class Administration
    {
        private string id;
        private string password;
        private string name;
        private string surname;
        private string age;
       
        private static Administration obj;

        private Administration(string id, string password, string name, string surname, string age)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public static Administration getInstance(string id, string password, string name, string surname, string age)
        {
            if (obj == null)
            {
                obj = new Administration(id, password, name, surname, age);
                return obj;
            }
            return null;
        }

    }
}
#endregion