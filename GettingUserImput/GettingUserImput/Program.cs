using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingUserImput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Dear " + name + ", Kindly enter your age: ");
            string age = Console.ReadLine();

            Console.Write("Dear " + name + ", You are " + age + " years old");

            Console.ReadLine();
        }
    }
}
