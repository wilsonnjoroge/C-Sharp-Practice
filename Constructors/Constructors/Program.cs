using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cretaing books by using the constructor in the books class
            Books book1 = new Books("Mstahiki Meya", "Ken Walibora", 167);
            Books book2 = new Books("Damu Nyeusi", "Ken Walibora", 687);
            Books book3 = new Books("Mayai Waziri wa Marathi", "Mbona Kambona", 890);

            Console.WriteLine("Book 1 title: " + book1.title);
            Console.WriteLine("Book 1 author: " + book1.author);
            Console.WriteLine("Book 1 pages: " + book1.pages);

            Console.WriteLine("Book 2 title: " + book2.title);
            Console.WriteLine("Book 2 author: " + book2.author);
            Console.WriteLine("Book 2 pages: " + book2.pages);

            Console.WriteLine("Book 3 title: " + book3.title);
            Console.WriteLine("Book 3 author: " + book3.author);
            Console.WriteLine("Book 3 pages: " + book3.pages);


            Console.ReadLine();
        }
    }
}
