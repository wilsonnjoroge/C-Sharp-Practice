using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Atributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Song winner = new Song("I am a winner", "Delemere", 300);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(winner.title); // normal attributes of the Song class (Keeps on changing)
            Song blessed = new Song("Blessed soul", "The Gospel Gurus", 600);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(blessed.title); // normal attributes of the Song class (Keeps on changing)

            // Static attribute
            Console.WriteLine(Song.songCount);

            Console.ReadLine();
        }
    }
}
