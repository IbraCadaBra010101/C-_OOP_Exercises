using System;

namespace week5
{
    public class Shapes
    {
        public static IShape Shape;

        public Shapes(IShape shape)
        { 
            Shape = shape;
        }
        public void PrintShape(string color, int width, int height )
        {
            Console.WriteLine(
                $"Area:{Shape.GetArea(width, height)} Color: {Shape.GetColor(color)} Name: {Shape.GetName()}");
        }
    }
}