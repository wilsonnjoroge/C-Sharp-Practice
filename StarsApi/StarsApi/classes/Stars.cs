using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarsApi.interaces;

namespace StarsApi.classes
{
    public class Stars : WriteStars
    {

        public void WriteUpsidedownRightAngleStars()
        {
            Console.WriteLine("Please input the number of stars for this rows: ");
            string numberOfRows = Console.ReadLine();

            int rows = int.Parse(numberOfRows);

            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void WriteUprightRightAngleStars()
        {
            /* To print Stars in descending order 
                *
                **
                ***
                ****
                *****
                ******
                            */

            Console.Write("Enter the number of rows For this pattern: ");
            int numRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numRows; i++) // Track the number of stars printed at each line ie increasing by 1
            {
                for (int j = 1; j <= i; j++) // Prints the stars at each line 
                {
                    Console.Write("*");
                }

                // Moves to the next line after printing
                Console.WriteLine();
            }

        }



    }
}
