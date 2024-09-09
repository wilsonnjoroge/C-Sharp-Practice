using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 1, 22, 13, 71, 45, 56, 87, 108, };

            // To print the first number in the array
            Console.WriteLine(luckyNumbers[0]);

            // To print all the numbers in the array
            foreach (int number in  luckyNumbers)
            {
                Console.Write( number );
            }

            // To print the numbers in []
            string output = "[" + string.Join(", ", luckyNumbers) + "]";
            Console.WriteLine("\n" + "Array in []: " + output);

            // To define the capacity of an array
            string[] cars = new string[5];
            cars[0] = "Volvo";
            cars[1] = "Audi";
            cars[2] = "Merscedes Benz";
            cars[3] = "Honda";

            string Cars = "[" + string.Join(", ", cars) + "]";
            Cars = Cars.TrimEnd(',', ' '); // To trim the extra comma at the end of the last item
            Console.WriteLine(Cars);

            Console.ReadLine();
        }
    }
}
