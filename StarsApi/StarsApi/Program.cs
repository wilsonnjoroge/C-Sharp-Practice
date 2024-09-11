

using StarsApi.classes;

namespace StarsApi
{
    class Program
    {
        static void Main (String[] args)
        {
            Stars stars = new Stars();

            stars.WriteUpsidedownRightAngleStars();

            stars.WriteUprightRightAngleStars();

            stars.WriteInvertedRightAngleStars();

            stars.WriteEquilateralTriangleStars();


            Console.ReadLine();
        }
    }
}
