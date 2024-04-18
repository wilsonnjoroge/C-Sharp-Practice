using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To print a plain string
            Console.WriteLine("Wilson Njoroge");

            // To write Wilson and Njoroge in different lines (use \n )
            Console.WriteLine("Wilson\nNjoroge");

            // To add quotes in a string ( use \" )
            Console.WriteLine("Wilson \"Daktari\" Njoroge");

            // To store a string in a variable
            string name = "Wilson Njoroge";
            Console.WriteLine("Variable name holds the name: " + name);

            // To concatenate a string ( using + )
            string FirstName = "Wilson ";
            string LastName = "Njoroge";
            Console.WriteLine("The full name will be: " + FirstName + LastName);

            // Find out the characters in string
            string Name = "Wilson";
            Console.WriteLine("String name has " + Name.Length + " characters");

            // To convrt string to upper case
            string Car = "audi";
            string NewCar = Car.ToUpper();
            Console.WriteLine("Name of the car converted to upper case will be: " + Car.ToUpper());
            Console.WriteLine("Name of the car converted to lower case will be: " + NewCar.ToLower());

            // To check if a string contains certain phrases
            string carModel = "Mercedes Benz";
            Console.WriteLine("Does the Car model contain the word Benz? " + carModel.Contains("Benz"));  // Will output True


            Console.ReadLine();
        }
    }
}
