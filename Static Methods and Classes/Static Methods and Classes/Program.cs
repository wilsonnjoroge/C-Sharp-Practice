using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Methods_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // square root method in the Math Class
            Console.WriteLine(Math.Sqrt(144));

            // Can create an instance since it's not static
            UsefulTools tools = new UsefulTools();
            UsefulTools.sayHi("Wilson");


            Console.ReadLine();
        }
    }
}
