using System;
using System.Drawing;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args) {}
    }

    public class UiControl
    {
        public string Id { get; set;}
        public Size Size { get; set;}
        public Position TopLedt { get; set;}

        public virtual void Draw()
        {

        }

        public void Focus()
        {
            Console.WriteLine("Received focus. ");
        }
    }
}
