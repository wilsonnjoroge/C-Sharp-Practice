using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Atributes
{
    internal class Song
    {
        // attributes
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        // Constructor
        public Song( string aTitle, string aArtist, int dDuration)
        {
            title = aTitle; // normal
            artist = aArtist; // normal
            duration = dDuration; // normal
            songCount++; // Static
        }
    }
}
