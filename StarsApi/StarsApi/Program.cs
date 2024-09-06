

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


            Console.ReadLine();
        }
    }
}
