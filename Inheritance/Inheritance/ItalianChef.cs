using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ItalianChef : Chef
    {
        public void MakePasta ()
        {
            Console.WriteLine("The italian chef makes Pasta");
        }

        // To override a virtual method from the super class, you must include the override keyword
        public override void MakeSpecialDiet()
        {
            Console.WriteLine("The chef makes Pizza");
        }
    }
}
