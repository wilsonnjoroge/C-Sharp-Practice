
using System;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes Chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }

        // The virtual means that it can overwritten in other sub classes
        public virtual void MakeSpecialDiet()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }


        // 1. Base Class and Derived Class:
        // Base class
        public class Animal
        {
            public string Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating.");
            }
        }

        // Derived class
        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine($"{Name} is barking.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Dog myDog = new Dog();
                myDog.Name = "Buddy";
                myDog.Eat();   // Inherited from Animal
                myDog.Bark();  // Specific to Dog
            }
        }


        // 2. Method Overriding:
        public class Animal2
        {
            public virtual void MakeSound2()
            {
                Console.WriteLine("Animal sound");
            }
        }

        public class Dog2 : Animal2
        {
            public override void MakeSound2()
            {
                Console.WriteLine("Bark");
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {
                Animal2 myAnimal = new Animal2();
                myAnimal.MakeSound2();  // Output: Animal sound

                Dog2 myDog = new Dog2();
                myDog.MakeSound2();  // Output: Bark
            }
        }


        // 3. base Keyword:
        public class Animal3
        {
            public virtual void MakeSound3()
            {
                Console.WriteLine("Animal sound");
            }
        }

        public class Dog3 : Animal3
        {
            public override void MakeSound3()
            {
                base.MakeSound3();  // Calls the base class version
                Console.WriteLine("Bark");
            }
        }

        class Program3
        {
            static void Main(string[] args)
            {
                Dog3 myDog = new Dog3();
                myDog.MakeSound3();  // Output: Animal sound
                                    
            }
        }

        // 4. Abstract Classes and Methods:
        public abstract class Animal4
        {
            public abstract void MakeSound4();  // Abstract method
        }

        public class Dog4 : Animal4
        {
            public override void MakeSound4()
            {
                Console.WriteLine("Bark");
            }
        }

        public class Cat4 : Animal4
        {
            public override void MakeSound4()
            {
                Console.WriteLine("Meow");
            }
        }

        class Program4
        {
            static void Main(string[] args)
            {
                Animal4 myDog = new Dog4();
                myDog.MakeSound4();  // Output: Bark

                Animal4 myCat = new Cat4();
                myCat.MakeSound4();  // Output: Meow
            }
        }


        // 5. Sealed Classes and Methods
        public class Animal5
        {
            public virtual void MakeSound5()
            {
                Console.WriteLine("Animal sound");
            }
        }

        public class Dog5 : Animal5
        {
            public sealed override void MakeSound5()
            {
                Console.WriteLine("Bark");
            }
        }

        // This class will cause a compilation error because it attempts to override a sealed method
        public class Puppy : Dog5
        {
        // The following method will result in a compilation error:
        //public override void MakeSound()
        //{
        //    Console.WriteLine("Puppy sound");
        //}
    }


    class Program5
        {
            static void Main(string[] args)
            {
            Puppy myPuppy = new Puppy();
            myPuppy.MakeSound5(); // Will call the method in dog5 and print back
            }
        }


    //****************************************************************************************************
    //****************************************************************************************************

    // 1. Single Inheritance - a class (derived class) inherits from one and only one base class
    public class AnimalA
    {
        public void EatA()
        {
            Console.WriteLine("Animal eats");
        }
    }

    public class DogA : AnimalA
    {
        public void BarkA()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class ProgramA
    {
        static void Main()
        {
            DogA myDogA = new DogA();
            myDogA.EatA();  // Inherited from Animal
            myDogA.BarkA(); // Specific to Dog
        }
    }


    // 2. Multilevel Inheritance - a class is derived from another derived class, forming a chain of inheritance.
    public class AnimalB
    {
        public void EatB()
        {
            Console.WriteLine("Animal eats");
        }
    }

    public class MammalB : AnimalB
    {
        public void BreatheB()
        {
            Console.WriteLine("Mammal breathes");
        }
    }

    public class DogB : MammalB
    {
        public void BarkB()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class ProgramB
    {
        static void Main()
        {
            DogB myDogB = new DogB();
            myDogB.EatB();    // Inherited from Animal
            myDogB.BreatheB(); // Inherited from Mammal
            myDogB.BarkB();   // Specific to Dog
        }
    }


    // 3. Hierarchical Inheritance - multiple classes are derived from a single base class
    public class AnimalC
    {
        public void EatC()
        {
            Console.WriteLine("Animal eats");
        }
    }

    public class DogC : AnimalC
    {
        public void BarkC()
        {
            Console.WriteLine("Dog barks");
        }
    }

    public class CatC : AnimalC
    {
        public void MeowC()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class ProgramC
    {
        static void Main()
        {
            DogC myDogC = new DogC();
            myDogC.EatC();  // Inherited from Animal
            myDogC.BarkC(); // Specific to Dog

            CatC myCatC = new CatC();
            myCatC.EatC();  // Inherited from Animal
            myCatC.MeowC(); // Specific to Cat
        }
    }


    // 4. Multiple Inheritance - a class can inherit from more than one base class
    public interface IAnimal
    {
        void EatD();
    }

    public interface IPet
    {
        void PlayD();
    }

    public class DogD : IAnimal, IPet
    {
        public void EatD()
        {
            Console.WriteLine("Dog eats");
        }

        public void PlayD()
        {
            Console.WriteLine("Dog plays");
        }
    }

    class ProgramD
    {
        static void Main()
        {
            DogD myDogD = new DogD();
            myDogD.EatD();  // Implemented from IAnimal
            myDogD.PlayD(); // Implemented from IPet
        }
    }


}
