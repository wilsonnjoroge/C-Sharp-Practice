using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Movies xxubmission = new Movies("Xxubmission", "j. F. Franklin", "18+");
            Movies robbery = new Movies("The Robbery", "Don Yen", "PG-13");
            Movies shooter = new Movies("The Shooter", "Cynthia Rockline", "Action"); // will print NR since Action is not a rating

            Console.WriteLine(xxubmission.Rating);
            Console.WriteLine(robbery.Rating);
            Console.WriteLine(shooter.Rating);

            Console.ReadLine();
        }
    }
}
