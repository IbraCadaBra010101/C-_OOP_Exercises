using System;

namespace interfaceInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog rottweiler = new Dog();
            Fish salmon = new Fish();
            DisplayAnimal(salmon);
            DisplayLandAnimal(rottweiler);
        }
        public static void DisplayAnimal(IAquaticAnimal aquaticAnimal)
        {
            aquaticAnimal.Swim();
            Console.WriteLine("Color: {0}, Name: {1}", aquaticAnimal.Color, aquaticAnimal.Name);
        }

        public static void DisplayLandAnimal(ILandAnimal landAnimal)
        {
            landAnimal.Walk();
            landAnimal.Speak();
            Console.WriteLine("Color: {0}, Name: {1}", landAnimal.Color, landAnimal.Name);
        }


    }
}


//Interface inheritance
//Create an interface called Animal this interface should contain the properties Name, Color and the
//method speak().
//Create an interface called AquaticAnimal this interface should inherit from the interface Animal. It
//should contain the method swim
//Create an interface called LandAnimal this interface should inherit from the interface Animal. It
//should contain the method walk
//Create a class called Fish that implements the interface AquaticAnimal.
//Create a class called Dog that implements the interface LandAnimal
//Create a method called display animal that takes an animal as an in parameter and prints its
//properties and calls the speak method.
//Create a method that takes a LandAnimal and calls the display animal method while also calling the
//walk method. Do the same for AquaticAnimal.
//Create an instance of both Fish and Dog and test your methods.
