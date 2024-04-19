using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponent_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getPower(3, 5));

            Console.ReadLine();
        }

        static int getPower (int baseNum, int powerNum)
        {
            int result = 1;

            for (int i = 0; i < powerNum; i++)
            {
                result = result * baseNum;
            }


            return result;
        }
    }
}
