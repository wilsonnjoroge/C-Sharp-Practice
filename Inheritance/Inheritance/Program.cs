using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The methods in the super class (Chef)
            Chef chef = new Chef();
            chef.MakeChicken();

            //The methods in the super class (Chef) have been inherited by the sub class(ItalianChef)
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();

            // Method primarily in the italian chef class
            italianChef.MakePasta();

            //Override the methods
            chef.MakeSpecialDiet(); // will output bbq
            italianChef.MakeSpecialDiet(); // will potput pizza


            Console.ReadLine();
        }
    }
}
