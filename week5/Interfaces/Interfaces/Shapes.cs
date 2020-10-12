using System;

namespace Interfaces
{
    class Shapes
    {
        public void PrintShape(IShape shape)
        {
            Console.WriteLine($"A {shape.Color} {shape.Name} with an area of {shape.GetArea()}");
        }

    }
}