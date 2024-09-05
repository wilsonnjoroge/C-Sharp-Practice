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



    }
}
