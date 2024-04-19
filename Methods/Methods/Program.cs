using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        // Method with no parameters/args
        static void Greetings()
        {
            Console.WriteLine("Hello Kiongozi");
        }

        // Methods with single parameter/args
        static void SpecificGreeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        // Methods with multiple parameters/args
        static void Greeting2(string name, int age)
        {
            Console.WriteLine("Hello " + name + ". You are " + age + " years old");
        }

        // Methods with a return value
        static int cubeNumber(int number)
        {
            int result = number * number * number;
            return result;
        }

        static void Main(string[] args)
        {
            Greetings();
            SpecificGreeting("Mkuu");
            SpecificGreeting("Bazuu");
            Greeting2("Baba Yao", 23);
            Greeting2("Mama Yao", 20);
            Greeting2("Babu Yao", 73);

            // Access the method directly and console it
            Console.WriteLine(cubeNumber(5));

            // Assingning the method a new variable
            int cubedNumber = cubeNumber(8);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();
        }

    }
}
