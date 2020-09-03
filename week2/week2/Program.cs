using System;
using System.Collections.Generic;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {

            // For();
            // sumOfNum();
            // calculateFirstTenNums();
            // sumAndAverage();
            // numberOfEvenAndOdd();
            // multiplicationTable();
            // PrintPattern();
            // FizzBuzz();
            // SquareOfStars();
            // validateInput();
            // CalculateIncome();
        }

        #region For0-9
        //static void For()
        //        {
        //            for (int i = 0; i < 10; i++)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        #endregion
        #region sumOfNumZeroToNine
        //static void sumOfNum()
        //{   
        //    Console.WriteLine(" Please enter a number");
        //    int userInput = int.Parse(Console.ReadLine());
        //    int sum = 0;

        //    for (int i = 0; i < userInput; i++)
        //    {
        //        sum += i;
        //        Console.WriteLine(sum);
        //    } 

        //} 

        //static void calculateFirstTenNums()
        //{
        //    int sum = 0; 
        //    for (int i = 0; i <= 9; i++)
        //    {
        //        sum += i; 
        //    }
        //    Console.WriteLine(sum);
        //} 
        #endregion
        #region ReadingNumbers

        //static void sumAndAverage()
        //{
        //    double sum = 0;
        //    double average = 0;
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("Enter a number");
        //        double userInput = double.Parse(Console.ReadLine());
        //        sum += userInput;
        //        average = sum / i;
        //    }
        //    Console.WriteLine(average + " :average");
        //    Console.WriteLine(sum + " :sum");
        //}

        #endregion
        #region Number of even and uneven numbers

        //static void numberOfEvenAndOdd()
        //{
        //    Console.WriteLine("Please enter a number! ");
        //    int userInPut = int.Parse(Console.ReadLine());
        //    int amountOfEven = 0;
        //    int amountOfOdd = 0; 
        //    for (int i = 1; i <= userInPut; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.WriteLine(i + " is even ");
        //            amountOfEven++;
        //        }
        //        else
        //        {
        //            Console.WriteLine(i + " is odd ");
        //            amountOfOdd++; 
        //        }
        //    }
        //    Console.WriteLine(" Amount of even: {0} ", amountOfEven);
        //    Console.WriteLine(" Amount of even: {0} ", amountOfOdd);
        //}

        #endregion
        #region Multiplication table

        //static void multiplicationTable()
        //{
        //    Console.WriteLine("Enter a number! ");
        //    int userInput = int.Parse(Console.ReadLine());
        //    for (int i = 0; i <= userInput; i++)
        //    { 
        //        int product = i * userInput;
        //       Console.WriteLine("{0} * {1} = {2}" , i, userInput, product);
        //    }
        //}
        #endregion
        #region PrintPattern
        //static void PrintPattern()
        //{
        //    string star = "*";
        //    int maxStars = 4;
        //    string stars = "";
        //    for (int i = 0; i <= maxStars; i++)
        //    {
        //        stars += star;
        //        Console.WriteLine(stars);
        //    }
        //    for (int j = 1; j <= maxStars; j++)
        //    {
        //        string newStars = stars.Remove(0, j);
        //        Console.WriteLine(newStars);
        //    }
        //}
        #endregion
        #region FizzBuzz
        //static void FizzBuzz()
        //{
        //    for (var i = 1; i <= 50; i++)
        //    {

        //        if (i % 3 == 0)
        //        {
        //            Console.WriteLine("Fizz");
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            Console.WriteLine("Buzz");

        //        }
        //        else if (i % 5 == 0 && i % 3 == 0)
        //        {
        //            Console.WriteLine("FizzBuzz");
        //        }
        //        else
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        #endregion
        #region SquareOfStars

        //static void SquareOfStars()
        //{
        //    int sizeOfSide = int.Parse(Console.ReadLine());
        //    string star = "*";
        //    string horizontalStars = "";
        //    string verticalStars = "";
        //    for (int i = 0; i < sizeOfSide; i++)
        //    {
        //        horizontalStars += star + "";
        //    }

        //    for (int i = 0; i < sizeOfSide; i++)
        //    {
        //        if (i == 0 || i == sizeOfSide -1 )
        //        {
        //            verticalStars += star;
        //        }
        //        else
        //        {
        //            verticalStars += " ";
        //        }
        //    }

        //    Console.WriteLine(horizontalStars);
        //    for (int i = 0; i < sizeOfSide -2; i++)
        //    {
        //              Console.WriteLine("\n" +verticalStars  );
        //    }
        //    Console.WriteLine("\n" + horizontalStars);
        //}
        #endregion
        #region ValidateInput
        //static void validateInput()
        //{
        //    Console.WriteLine("Enter password!");
        //    string correctInput = "Foo Bar";
        //    string userInput = Console.ReadLine();
        //    bool repeat = true;

        //    do
        //    {
        //        if (correctInput != userInput)
        //        {
        //            Console.WriteLine("Write the correct password!");
        //            userInput = Console.ReadLine();
        //        }
        //        else
        //        {
        //            repeat = false;
        //            Console.WriteLine(userInput + " is correct");
        //        }
        //    } while (repeat);

        //    //while (true)
        //    //{
        //    //    if (correctInput != userInput)
        //    //    {
        //    //        Console.WriteLine("Write the correct password! {0} is not correct.", userInput);
        //    //        userInput = Console.ReadLine();
        //    //    }
        //    //    else
        //    //    {
        //    //        Console.WriteLine("Great, logging in!");
        //    //        break;
        //    //    }

        //    //}

        //}

        #endregion
        #region CalculateIncome
        //static void CalculateIncome()
        //{

        //    double earningsPerWeek = 200;
        //    double commission = 0;
        //    double[] soldItems = {239.99, 129.75, 99.95, 350.89 };
        //    bool repeat = true;

        //    for (int i = 0; i < soldItems.Length; i++)
        //    {
        //        Console.WriteLine("{0} {1}", i + 1, soldItems[i] + "\n");
        //    }
        //    Console.WriteLine("Enter the number for each price item you have sold!\nPress 0 to get the total weekly earnings\nand sales commission for the items you sold!. ");
        //    int saleCategory = int.Parse(Console.ReadLine());
        //    Console.Clear();
        //    do
        //    {
        //        if (saleCategory != 0 && !(saleCategory > 4 || saleCategory < 1))
        //        {

        //            Console.WriteLine("List of items for sale");
        //            for (int i = 0; i < soldItems.Length; i++)
        //            {
        //                Console.WriteLine("Sale Categories: {0}", soldItems[i] + " \n");
        //            }

        //            commission += soldItems[saleCategory - 1]  * 0.09;
                  
        //            for (int i = 0; i < soldItems.Length; i++)
        //            {
        //                Console.WriteLine("{0} {1}", i + 1, soldItems[i] + "\n");
        //            }  
                    
        //            Console.WriteLine("Your weekly earnings are: {0} and comission {1} $ \nAny more sales you would like to add?", earningsPerWeek, commission);
        //            saleCategory = int.Parse(Console.ReadLine());
        //            Console.Clear();
        //        } else if (saleCategory > 4 || saleCategory < 0) 
        //        {
        //            Console.WriteLine("List of items for sale");
        //            for (int i = 0; i < soldItems.Length; i++)
        //            {
        //                Console.WriteLine("Sale Categories: {0}", soldItems[i] + " \n");
        //            }
        //            Console.WriteLine("Error!\nNumber {0} is not a valid choice. Choose a number between 1 to 4 to select your price item");
        //            saleCategory = int.Parse(Console.ReadLine());
        //        }
        //        else
        //        {
        //            Console.WriteLine("TOTAL EARNINGS PREVIOUS WEEK {0} EARNED SALES COMMISION {1}: ", earningsPerWeek, commission);
        //            repeat = false;
        //        }


        //    } while (repeat);
        //}

        #endregion
    }
}
