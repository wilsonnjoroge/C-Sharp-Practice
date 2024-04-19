using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int index = 8;

            // While Loop
            while(index <= 5)
            {
                Console.WriteLine(index); // will not print any value 
                index++;
            }

            // Do While Loop
            do
            {    
                Console.WriteLine(index); // Will print value of index then try to increment it then the next code executed
                index++;
            }
            while (index <= 5);


            Console.ReadLine(); 
        }
    }
}
