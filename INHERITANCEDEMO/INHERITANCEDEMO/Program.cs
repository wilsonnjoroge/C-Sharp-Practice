
using System;


namespace INHERITANCEDEMO
{

    //Hierachical 

    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal Eating");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barking");
        }
    }

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Cat meowing");
        }
    }



    class Program
    {

        static void Main(string[] args )
        {

            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();

            Cat myCat = new Cat();
            myCat.Eat();
            myCat.Meow();
            
            
           

            Console.ReadLine();
            
        }
    }

}