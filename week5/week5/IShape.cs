using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace week5
{
    public interface IShape
    {
        public string Name { get;}
        public string Color { get; }
        int GetArea();
        string GetColor() { return Color; }
        string GetName() { return Name; }
    }

}