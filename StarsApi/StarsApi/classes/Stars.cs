
using StarsApi.interaces;

namespace StarsApi.classes
{
    public class Stars : IWriteStars
    {

        public void WriteUpsidedownRightAngleStars()
        {
            /* To print Stars in descending order 
               ******
               *****
               ****
               ***
               **
               *
                   */ 

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

        public void WriteInvertedRightAngleStars()
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

            for (int i = 1; i <= numRows; i++)
            {
                for (int j = numRows; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void WriteEquilateralTriangleStars()
        {
            /* To print Stars in descending order 
                     *
                    ***
                   *****
                  *******
                 *********
                ***********
                            */

            Console.Write("Enter the number of rows For this pattern: ");
            int numRows = int.Parse(Console.ReadLine());

            int rows = numRows;
            for (int i = 1; i <= rows; i++) // Track the number of rows
            {
                for (int j = 1; j <= rows - i; j++) // Print the leading spaces that decreases as the number increases
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i) - 1; k++) // Print stars in an odd number manner ie 1,3,5,7,9,11
                {
                    Console.Write("*");
                }

                // Moves to the next line after printing
                Console.WriteLine();
            }

        }
    }
}
