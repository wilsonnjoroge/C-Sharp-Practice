using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Wilson";
            int age = 26;
            char firstNameIitial = 'W';
            char middleNameIitial = 'N';
            char lastNameIitial = 'W';
            bool isMarried = false;
            double weight = 62.5;

            Console.WriteLine(name + " is " + age + " years old");
            Console.WriteLine( name + " is " + weight + "Kgs");
            Console.WriteLine(name + "'s professional initials are: " + firstNameIitial + "." + middleNameIitial + "." + lastNameIitial );
            Console.WriteLine("Is " + name + " married? " + isMarried);
            Console.ReadLine();
        }
    }
}
