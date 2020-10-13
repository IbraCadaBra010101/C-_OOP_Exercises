using System;

namespace Interfaces
{
    class Triangle: IShape, IShapeDisplay
    {
        public string Color { get; set; } = "Red";
        public string Name { get; } = "Triangle";
        public double Width { get; set; } = 4;
        public double Height { get; set; } = 4;
        public double GetArea()
        {
            return (Width  * Height) / 2;
        }

        public void Display()
        {
            Console.WriteLine($"Color: {Color} Name:{Name} Area:{GetArea()}");

        }
    }
}