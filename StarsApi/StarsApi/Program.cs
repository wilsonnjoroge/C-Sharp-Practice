

using StarsApi.classes;

namespace StarsApi
{
    class Program
    {
        static void Main (String[] args)
        {
            Stars upsidedownRightAngleStars = new Stars();
            upsidedownRightAngleStars.WriteUpsidedownRightAngleStars();

            Stars uprightRightAngleStars = new Stars();
            uprightRightAngleStars.WriteUprightRightAngleStars();

            Stars invertedRightAngleStars = new Stars();
            invertedRightAngleStars.WriteInvertedRightAngleStars();

            Stars equilateralTringleStars = new Stars();
            equilateralTringleStars.WriteEquilateralTriangleStars();


            Console.ReadLine();
        }
    }
}
