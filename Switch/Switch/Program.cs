using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }

            return dayName;
        }

            
       

        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));
            Console.WriteLine(GetDay(1));
            Console.WriteLine(GetDay(2));
            Console.WriteLine(GetDay(3));
            Console.WriteLine(GetDay(4));
            Console.WriteLine(GetDay(5));
            Console.WriteLine(GetDay(6));
            Console.WriteLine(GetDay(70));

            Console.ReadLine();
        }
    }
}
