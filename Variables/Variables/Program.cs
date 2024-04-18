using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.Write(" World");
            Console.WriteLine(" Great improvement");

            string name = "Wilson";
            Console.WriteLine("My name is " + name);

            string firstName = "Wilson";
            string lastName = "Wanderi";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            int salary = 200;
            int allowances = 50;
            int totalSalary = salary + allowances;
            Console.WriteLine(totalSalary);


            Console.ReadLine();
        }
    }
}
