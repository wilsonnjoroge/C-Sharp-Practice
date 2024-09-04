
namespace Stars_Printing
{


    class Program
    {
        static void Main(string[] args)
        {
            /* To print Stars in descending order 
                ******
                *****
                ****
                ***
                **
                *
                            */

            for(int i = 6; i >= 1; i--) // Track the number of stars printed at each line ie reducing by 1
            {
                for (int j = 1; j <= i; j++) // Prints the stars at each line 
                {
                    Console.Write("*");
                }

                // Moves to the next line after printing
                Console.WriteLine();
            }


            /* To print Stars in descending order 
                *
                **
                ***
                ****
                *****
                ******
                            */

            for (int i = 1; i <= 6 ; i++) // Track the number of stars printed at each line ie increasing by 1
            {
                for (int j = 1; j <= i; j++) // Prints the stars at each line 
                {
                    Console.Write("*");
                }

                // Moves to the next line after printing
                Console.WriteLine();
            }


            /* To print Stars in descending order 
                     *
                    **
                   ***
                  ****
                 *****
                ******
                            */

            for (int i = 1; i <= 6; i++) // Track the number of stars printed at each line ie increasing by 1
            {
                for (int j = 6; j > i; j--) // Print the leading spaces that decreases as the number increases
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++) // Prints the stars at each line 
                {
                    Console.Write("*");
                }

                // Moves to the next line after printing
                Console.WriteLine();
            }


            /* To print Stars in descending order 
                     *
                    ***
                   *****
                  *******
                 *********
                ***********
                            */

            int rows = 6;
            for(int i = 1; i <= rows ; i++) // Track the number of rows
            {
                for (int j = 1; j <= rows - i ; j++) // Print the leading spaces that decreases as the number increases
                {
                    Console.Write(" ");
                }

                for(int k = 1; k <= (2 * i) -1; k++) // Print stars in an odd number manner ie 1,3,5,7,9,11
                {
                    Console.Write("*");
                }

                // Moves to the next line after printing
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
