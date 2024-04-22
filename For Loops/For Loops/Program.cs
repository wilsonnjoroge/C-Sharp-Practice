using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Looping throug numbers
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // Looping through an Array
            int[] luckyNumbers = { 34, 22, 65, 65, 34, 76, 44 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
                
            }

            Console.ReadLine();
        }
    }
}
