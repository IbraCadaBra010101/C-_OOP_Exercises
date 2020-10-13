using System;

namespace interfaceInheritance
{
    class Dog : ILandAnimal
    {
        public string Name { get; set; } = "Rex";
        public string Color { get; set; } = "Brown";
        public void Speak()
        {
            Console.WriteLine("voff voff");
        }

        public void Walk()
        {
            Console.WriteLine("Walking dog");
        }
    }
}