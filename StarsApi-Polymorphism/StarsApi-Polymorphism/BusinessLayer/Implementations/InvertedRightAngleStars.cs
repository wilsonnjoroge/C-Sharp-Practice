using StarsApi_Polymorphism.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsApi_Polymorphism.BusinessLayer.Implementations;

public class InvertedRightAngleStars : IShapeDrawer
{
    public void DrawShape(int numberOfRows)
    {
        /* To print Stars in descending order
                  *
                 **
                ***
               ****
              *****
             ******
                    
                    */

        for (int i = 1; i <= numberOfRows; i++)
        {
            for (int j = numberOfRows; j > i; j--)
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
}
