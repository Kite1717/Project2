using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Logger
    {
        private static Dictionary<string, string> logs = new Dictionary<string, string>();


        public static void addLog(string key , string log)
        {
            logs.Add(key, log);
        }
        
        public static bool writeToFile()
        {
           

            if (!File.Exists("Log.txt")) File.Create("Log.txt");
            string[] data = readToFile(false);

            if (data == null) //if first exit process 
            {
                using (StreamWriter sw = File.CreateText("Log.txt"))
                {
                    foreach (string i in logs.Values) sw.WriteLine(i);
                }
                return true;
            }

           
           //TODO Fix 
                bool flag = true;
                for (int i = 0; i < logs.Values.Count; i++)
                {
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (data[j].Substring(0, 10).Equals(logs.Values.ToArray()[i].Substring(0, 10)))
                        {
                            flag = false;
                            break;
                           
                        }

                    }
                    if (flag)
                    {
                        using (StreamWriter sw = File.CreateText("Log.txt"))
                        {
                            sw.WriteLine(logs.Values.ToArray()[i]);
                        }
                    }
                    flag = true;

                }


            return true;
        }

        /// <summary>
        /// opens log file and prints contents to console
        /// </summary>
        /// <param name="show">Displaying for admin</param>
        /// <returns>readed data</returns>
        public static string[] readToFile(bool show)
        {
            if (!File.Exists("Log.txt")) return null;
         
           string[] exps =  File.ReadAllLines("Log.txt");

            if (exps.Length == 0) return null;

            if (show)
            {
                Process.Start(new FileInfo("Log.txt").Directory.FullName + "\\Log.txt");
                foreach (string i in exps) Console.WriteLine(i);
            }

               return exps;
        }
    }
}
