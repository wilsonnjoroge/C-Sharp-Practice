using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Signs
{
    internal class Program
    {

        // Getting maximum while comparing two numbers
        static int GetMax1(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        // Getting maximum while comparing more than two numbers
        static int GetMax2 (int num3, int num4, int num5)
        {
            int result2;

            if(num3 >= num4 && num3 >= num5)
            {
                result2 = num3;

            } else if (num4 >= num5 )
            {
                result2 = num4; 
            } else
            {
                result2 = num5;
            }

            return result2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetMax1(20, 12));

            Console.WriteLine(GetMax2(13,55,5));
            Console.WriteLine(GetMax2(46, 72, 83));


            Console.ReadLine();
        }

    }
}
