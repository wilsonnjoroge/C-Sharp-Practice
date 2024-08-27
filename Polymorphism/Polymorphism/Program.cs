using System;

public class Chef
{
    public static void Main(string[] args)
    {
        // Base chef will output what is in the base class
        Chef baseChef = new Chef();
        baseChef.Cooks();

        // Derived class will output what is in the derived class
        KenyanChef kenyanChef = new KenyanChef();
        kenyanChef.Cooks();

        // Polymorphism: base class reference pointing to derived class object
        Chef polymorphicChef = new KenyanChef();
        polymorphicChef.Cooks();

        // Wait for user input before closing the console
        Console.ReadLine();
    }

    public virtual void Cooks()
    {
        Console.WriteLine("The chef cooks a meal.");
    }
}

public class KenyanChef : Chef
{
    public override void Cooks()
    {
        Console.WriteLine("The Kenyan chef cooks Omena.");
    }
}
