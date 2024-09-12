using StarsApi_Polymorphism.BusinessLayer.Interfaces;

namespace StarsApi_Polymorphism.BusinessLayer.Implementations;

public class PyramidStars : IShapeDrawer
{
    public void DrawShape(int numberOfRows)
    {
        /* To print Stars in descending order 
                 *
                ***
               *****
              *******
             *********
            ***********
                        */

        for (int i = 1; i <= numberOfRows; i++)
        {
            for (int j = 1; j <= numberOfRows - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
