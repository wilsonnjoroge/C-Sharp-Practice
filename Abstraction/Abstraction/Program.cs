// Abstract class
public abstract class Shape
{
    // Abstract method (no implementation here)
    public abstract double CalculateArea();

    // Concrete method (implementation provided)
    public void DisplayShape()
    {
        Console.WriteLine("Displaying the shape.");
    }
}

// Derived class implementing the abstract method
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implementation of the abstract method
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Shape shape = new Shape(); // Error: Cannot instantiate an abstract class

        // Create a Circle object
        Shape circle = new Circle(5.0);

        // Display the shape
        circle.DisplayShape();

        // Calculate and display the area of the circle
        double area = circle.CalculateArea();
        Console.WriteLine($"The area of the circle is: {area}");

        Console.ReadLine();
    }
}

