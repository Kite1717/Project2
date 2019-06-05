using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class User
    {
        private string id;
        private string password;
        private string name;
        private string surname;
        private int age;
        List<Reservation> reservations;
        private bool isMember;

        /// <summary>
        ///it takes all the information necessary for a user and creates the required information.
        /// </summary>
        /// <param name="ıD"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="password"></param>
        /// <param name="age"></param>
        public User(string id, string name, string surname, string password, int age)
        {

            this.id = id;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.age = age;
            reservations = new List<Reservation>();
            isMember = false;
        }
       
        // General properties for update process
        /// <summary>
        /// Only contains letter and space (Not NULL ,not same)
        /// </summary>
        public string ID
        {
            get
            {
                return this.ID;
            }
            set
            {
                if (value.Length >= 6 && value != null ) this.ID = value;
                else
                {
                    if (value != null)
                        Logger.addLog(value, DateTime.Now.ToString("MM/dd/yyyy") +
                            "  ArgumentException :  status => Property , class => User , name => ID , value => " + value);


                    else
                        Logger.addLog("name(NULL)", DateTime.Now.ToString("MM/dd/yyyy") +
                            "  ArgumentNullException :  status => Property , class => User , name => ID , value => name(NULL)");

                    throw new ArgumentException();

                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!value.Equals(this.name) && value != null && value.All(c => Char.IsLetter(c) || c == ' '))
                    this.name = value;
                else
                {
                   if(value != null)
                   Logger.addLog(value, DateTime.Now.ToString("MM/dd/yyyy") +
                       "  ArgumentException :  status => Property , class => User , name => Name , value => " + value);


                   else
                 Logger.addLog("name(NULL)", DateTime.Now.ToString("MM/dd/yyyy") + 
                     "  ArgumentNullException :  status => Property , class => User , name => Name , value => name(NULL)");

                    throw new ArgumentException();

                }

                
            }
        }

        /// <summary>
        /// Only Contains letter  and it is not null
        /// </summary>
        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                if (!value.Equals(this.surname) && value != null && value.All(Char.IsLetter))
                   this.surname = value;

                else
                {
                    if (value != null)
                        Logger.addLog(value, DateTime.Now.ToString("MM/dd/yyyy") +
                            "  ArgumentException :  status => Property , class => User , name => Surname , value => " + value);

                    else 
                        Logger.addLog("surname(NULL)", DateTime.Now.ToString("MM/dd/yyyy") + 
                            "  ArgumentNullException :  status => Property , class => User , name => Surname , value => surname(NULL)");

                    throw new ArgumentException();

                }

            }
        }

        /// <summary>
        ///  it contains all marking and 
        ///  must have at least 6 digits
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                if (!value.Equals(this.password) && value != null && value.Length >= 6)
                    this.password = value;

                else
                {
                    if (value != null)
                        Logger.addLog(value, DateTime.Now.ToString("MM/dd/yyyy") + 
                            "  ArgumentException :  status => Property , class => User , name => Password , value => " + value);

                    else
                        Logger.addLog("password(NULL)", DateTime.Now.ToString("MM/dd/yyyy") + 
                            "  ArgumentNullException :  status => Property , class => User , name => Password , value => password(NULL)");

                    throw new ArgumentException();

                }
            }
        }

        /// <summary>
        ///can only register older than eighteen 
        /// </summary>
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if ( value >= 18)
                    this.age = value;
                else { 
         
                        Logger.addLog(value.ToString(), DateTime.Now.ToString("MM/dd/yyyy") + 
                            "  ArgumentException :  status => Property , class => User , name => Age , value => " + value);
                    throw new ArgumentException();

                }
            }
        }









    }
}




