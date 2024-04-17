using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameApp
{
     class Variables
    {
       public string name = "Wilson";
       public int age = 26;

        static void Main(string[] args)
        {
            Variables s = new Variables();
            Console.WriteLine(s.name + " is " + s.age + " years old");

            Console.ReadLine();

        }
    }
}
