namespace Interfaces
{
    interface IShape
    { 
        public string Color { get; set; }
        public string Name { get; }
        double GetArea();
    }


}