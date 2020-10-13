using System;

namespace Interfaces
{
    class Square : IShape, IShapeDisplay
    {
        public string Color { get; set; } = "blue";
        public string Name { get; } = "square";
        public double Height { get; set; } = 5;
        public double Width { get; set; } = 5;
        public double GetArea()
        {
            return Width * Height;
        }

        public void Display()
        {
            Console.WriteLine($"Color: {Color} Name:{Name} Area:{GetArea()}");
        }
    }
}