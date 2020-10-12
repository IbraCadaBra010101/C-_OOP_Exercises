namespace Interfaces
{
    class Triangle: IShape
    {
        public string Color { get; set; } = "Red";
        public string Name { get; } = "Triangle";
        public double Width { get; set; } = 4;
        public double Height { get; set; } = 4;
        public double GetArea()
        {
            return (Width  * Height) / 2;
        }
    }
}