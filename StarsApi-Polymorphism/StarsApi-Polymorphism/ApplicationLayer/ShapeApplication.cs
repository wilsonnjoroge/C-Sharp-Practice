using StarsApi_Polymorphism.BusinessLayer.Implementations;
using StarsApi_Polymorphism.BusinessLayer.Interfaces;
using StarsApi_Polymorphism.DataLayer;
using System.Runtime.CompilerServices;

namespace StarsApi_Polymorphism.ApplicationLayer;

public class ShapeApplication
{

    private readonly INumberOfRowsRepository _numberOfRowsRepository;


    public ShapeApplication(INumberOfRowsRepository numberOfRowsRepository)
    {
        _numberOfRowsRepository = numberOfRowsRepository;
    }

    public void Run()
    {

        Console.WriteLine("Kinldy select a shape to draw:");
        Console.WriteLine("1. Pyramid");
        Console.WriteLine("2. Upright RightAngle Stars");
        Console.WriteLine("3. Upsidedown RightAngle Stars");
        Console.WriteLine("4. Inverted RightAngle Stars");

        string selection = Console.ReadLine();
        int choice = int.Parse(selection);

        Console.Write("Enter the number of rows for this pattern: ");
        string input = Console.ReadLine();
        int numberOfRows = int.Parse(input);

        

        if (!_numberOfRowsRepository.IsRowNumberValid(numberOfRows))
        {
            Console.WriteLine("Error: Number of rows not found in the list.");
            return;
        }

        IShapeDrawer shapeDrawer = choice switch
        {
            1 => new PyramidStars(),
            2 => new UprightRightAngleStars(),
            3 => new UpsidedownRightAngleStars(),
            4 => new InvertedRightAngleStars(),
            _ => throw new Exception("Invalid choice.")
        };

        shapeDrawer.DrawShape(numberOfRows);
    }

}
