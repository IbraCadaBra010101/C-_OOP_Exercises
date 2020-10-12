using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Choose shape from the following shape: Circle, Square, Triangle");
            var userInput = Console.ReadLine();
            Shapes shape = new Shapes();
            switch (userInput)
            {
                case "circle":

                    Circle createCircle = new Circle();
                    Console.WriteLine($"creating a {createCircle.Name.ToUpper()}:");
                    shape.PrintShape(createCircle);

                    break;
                case "square":
                    Square createSquare = new Square();
                    Console.WriteLine($"creating a {createSquare.Name}");
                    shape.PrintShape(createSquare);
                    break;
                case "triangle":
                    Triangle createTriangle = new Triangle();
                    Console.WriteLine($"creating a {createTriangle.Name}");
                    shape.PrintShape(createTriangle);
                    break;
            }
        }


    }
}

//Create the classes square and circle that both 
//implement the shape interface. The user should be
//able to select which shape should be created. After 
//its created call print shape with the result. You
//should move the shape creation to a function that 
//returns a variable of type the shape interface.