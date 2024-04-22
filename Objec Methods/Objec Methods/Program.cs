using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objec_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating a student from the Students Object
            Students student1 = new Students("Medison", "Mathematics", 75);
            Students student2 = new Students("Hellena", "Mathematics", 45);

            // Using the hasPassed method that is inside the constructor of the Students class 
            Console.WriteLine(student1.hasPassed());
            Console.WriteLine(student2.hasPassed());


            Console.ReadLine();
        }
    }
}
