using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_and_Setters
{
    internal class Movies
    {
        public string name;
        public string actor;
        private string rating;

        public Movies(string aName, string aActor, string aRating)
        {
            name = aName;
            actor = aActor;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }

            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "18+" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }

                }
        }
    }
}

