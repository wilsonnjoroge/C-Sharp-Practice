using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // To add whole numbers
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            // To include decimals 
            Console.Write("Enter a decimal number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another decimal number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num3 + num4);

            Console.ReadLine();
        }
    }
}
