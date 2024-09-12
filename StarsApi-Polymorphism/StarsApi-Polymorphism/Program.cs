
using StarsApi_Polymorphism.ApplicationLayer;
using StarsApi_Polymorphism.DataLayer;

namespace StarsApi_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            INumberOfRowsRepository numberOfRowsRepository = new NumberOfRows();

            var shapeApp = new ShapeApplication(numberOfRowsRepository);
            shapeApp.Run();

            Console.ReadLine();
        }
    }
}

