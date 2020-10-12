using System;

namespace Interfaces
{
    class Square : IShape
    {
        public string Color { get; set; } = "blue";
        public string Name { get; } = "square";
        public double Height { get; set; } = 5;
        public double Width { get; set; } = 5;
        public double GetArea()
        {
            return Width * Height;
        }
    }
}