using System;

namespace interfaceInheritance
{
    class Fish : IAquaticAnimal
    {
        public string Name { get; set; } = "Goldie fish";
        public string Color { get; set; } = "Golden colored";
        public void Speak()
        {
            Console.WriteLine("Fish is speaking");
        }

        public void Swim()
        {
            Console.WriteLine(" Fish is Swimming...");
        }
    }
}