using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator(+,-,/,*): ");
            string op = Console.ReadLine();
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

           // Console.Clear();

            double result;
            if(op == "+")
            {
                result = num1 + num2;
                Console.WriteLine(result);

            } else if (op == "-")
            {
                result = num1 - num2;
                Console.WriteLine(result);

            } else if(op == "*")
            {
                result = num1 * num2;
                Console.WriteLine(result);

            }
            else if (op == "/")
            {
                result = num1 / num2;
                Console.WriteLine(result);

            }else
            {
                Console.WriteLine("Invalid Operator");
            }


            Console.ReadLine();
        }
    }
}
