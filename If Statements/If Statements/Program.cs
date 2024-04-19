using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;

            // If statement 
            if (isMale)
            {
                Console.WriteLine("You can have a free Prostrate cancer check-up");
            }


            bool isHungry = false;

            // If Else statement
            if (isHungry)
            {
                Console.WriteLine("Enter the kitchen and cook");
            }
            else
            {
                Console.WriteLine("Go to the park and chill");
            }

            bool isFemale = true;
            bool isTall = false;

            // If, Else If, Else
            if (isFemale && isTall)
            {
                Console.WriteLine("You are a tall female");
            } else if (isFemale && !isTall)
            {
                Console.WriteLine("You are a female but not tall");
            } else if ( !isFemale && isTall)
            {
                Console.WriteLine("You are not a female but you are tall");
            } else
            {
                Console.WriteLine("You are neither a female nor tall");
            }

            Console.ReadLine();
        }
    }

}
