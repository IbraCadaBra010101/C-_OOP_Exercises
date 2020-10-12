using System;

namespace week5
{
    class Triangel : IShape
    {
        public string Name { get; } = "Triangle";
        public string Color { get; set; }
        public int GetArea(string Name)
        {
            
        }
    }
}

//Create the classes square and circle that both
//implement the shape interface.
//The user should be
//able to select which shape should be created. After its
//created call print shape with the result. You
//should move the shape creation to a function that
////returns a variable of the shape interface type.