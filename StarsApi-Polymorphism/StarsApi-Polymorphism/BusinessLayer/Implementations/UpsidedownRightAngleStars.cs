using StarsApi_Polymorphism.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsApi_Polymorphism.BusinessLayer.Implementations;

public class UpsidedownRightAngleStars : IShapeDrawer
{
    /* To print Stars in descending order 
               ******
               *****
               ****
               ***
               **
               *
                   */
    public void DrawShape(int numberOfRows)
    {
        for (int i = numberOfRows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
