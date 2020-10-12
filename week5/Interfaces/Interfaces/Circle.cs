using System;
using Interfaces;

namespace Interfaces
{ 
    class Circle : IShape
    {
        public string Color { get; set; } = "Green";
        public string Name { get; } = "Circle";
        public double Radius { get; set; } = 5;
        public double GetArea()
        {
            return Math.PI* Radius;
        }
    }
}
