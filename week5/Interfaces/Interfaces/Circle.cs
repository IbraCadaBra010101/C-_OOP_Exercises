using System;
using Interfaces;

namespace Interfaces
{ 
    class Circle : IShape, IShapeDisplay
    {
        public string Color { get; set; } = "Green";
        public string Name { get; } = "Circle";
        public double Radius { get; set; } = 5;
        public double GetArea()
        {
            return Math.PI* Radius;
        }

        public void Display()
        {
            Console.WriteLine($"Color: {Color} Name:{Name} Area:{GetArea()}");
        }
    }
}
