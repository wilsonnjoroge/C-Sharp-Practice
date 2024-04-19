using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = 
            { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 }
            };

            // First item in the first Array
            Console.WriteLine(numberGrid[0,0]);

            // Second item in the first Array
            Console.WriteLine(numberGrid[0, 1]);

            // First item in the second Array
            Console.WriteLine(numberGrid[1, 0]);

            // Second item in the second Array
            Console.WriteLine(numberGrid[1, 1]);

            // First item in the third Array
            Console.WriteLine(numberGrid[2, 0]);

            // Second item in the third Array
            Console.WriteLine(numberGrid[2, 1]);




            Console.ReadLine();
        }
    }
}
