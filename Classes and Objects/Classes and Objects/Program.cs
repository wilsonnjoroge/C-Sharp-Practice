using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a book using the Book Object from the Book Class
            Book book1 = new Book();
            book1.title = "The River and The Source";
            book1.author = "Margaret Ogolla";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Betrayal in the City";
            book2.author = "Francis Imbugua";
            book2.pages = 260;

            Console.WriteLine("Book 1 title: " + book1.title);
            Console.WriteLine("Book 1 author: " + book1.author);
            Console.WriteLine("Book 1 pages: " + book1.pages);

            Console.WriteLine("Book 2 title: " + book2.title);
            Console.WriteLine("Book 2 author: " + book2.author);
            Console.WriteLine("Book 2 pages: " + book2.pages);

            Console.ReadLine();
        }
    }
}
