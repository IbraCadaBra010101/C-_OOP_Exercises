using System;
using System.Collections.Generic;
using System.Linq;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            // RemoveAllNegativeOccurences();
            // ConcatenateIndexWise();
            ReverseList();
        }
        #region create a list

        //List<int> nums = new List<int>();
        // for (int i = 0; i < 5; i++)
        // {
        //     nums.Add(i);
        // }

        // foreach (var number in nums)
        // {
        //     Console.WriteLine("The following numbers are in the list: {0}", number);
        // }
        //numbersInput();
        //List<string> colorList = new List<string>() { "red", "green", "white", "black", "pink", "yellow" };
        //List<string> result = RemoveFromList(colorList);
        //foreach (var s in result)
        //{ 
        //    Console.WriteLine(s);
        //}
        #endregion
        #region AddNumbers

        //static void numbersInput()
        //{
        //    List<int> nums = new List<int>() {1,2,3};

        //    for (int i = 0; i < 2; i++)
        //    {   Console.WriteLine("Which number would you like to add?");
        //        int userInput= int.Parse(Console.ReadLine());
        //        nums.Add(userInput);
        //    }
        //    Console.WriteLine("Numbers currently in list: ");
        //    foreach (var num in nums)
        //    {
        //         Console.WriteLine(num);
        //    }

        //}
        #endregion
        #region RemovingByIndex

        //static List<string> RemoveFromList(List<string> list)
        //{
        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        if (i == 0 || i == 4 || i == 5)
        //        {
        //            list.RemoveAt(i);
        //        }

        //    }
        //    return list;
        //}

        #endregion
        #region SumOfList

        //static void AddNumbers()
        //{
        //    List<int> numbers = new List<int>();
        //    int sum = 0;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine("Give me a number to save to the list?");
        //        int saveTheseNumbers = int.Parse(Console.ReadLine());
        //        numbers.Add(saveTheseNumbers);
        //    }
        //    Console.WriteLine("The following numbers were saved! ");
        //    foreach (var num in numbers)
        //    {
        //        Console.WriteLine("Number: {0} ", num);
        //        sum += num; 

        //    }
        //    Console.WriteLine("The sum of the numbers you added to the list is: {0}", sum);
        //}

        #endregion
        #region filteringOutNegativity

        //static void RemoveAllNegativeOccurences()
        //{
        //    var numbers = new List<int>() { 5, -5, 15, -4, 25, 50, -1 };
        //    for (int i = 0; i < numbers.Count; i++)
        //    {
        //        if (numbers[i] < 0)
        //        {
        //            numbers.RemoveAt(i);
        //        }
        //    }
        //    foreach (var num in numbers)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}


        #endregion
        #region ConcatingListIndexWise

        //static void combineByIndex()
        //{
        //    List<string> listOne = new List<string>() { "My", "na", "is", "Ti" };
        //    List<string> listTwo = new List<string>() { "y", "me", "is", "m" };
        //    List<string> combinedList = new List<string>();

        //    for (int i = 0; i < listOne.Count; i++)
        //    {
        //        if (listOne[i].Contains(listTwo[i]))
        //        {
        //            combinedList.Add(listOne[i]);
        //        }
        //        else
        //        {
        //            combinedList.Add(listOne[i] + listTwo[i]);
        //        }

        //    }
        //}


        #endregion


        //public static void ReverseList()
        //{
        //    // Med inbyggd C# util funktion Reverse()
        //    //var items = new List<int>() { 1, 2, 3, 4, 5 };
        //    //items.Reverse();
        //    //foreach (var n in items)
        //    //{
        //    //    Console.WriteLine(n);
        //    //}



        //    // Manuellt utan inbyggda funktiioner
        //    var tempList = new List<int>();
        //    var items = new List<int>() { 1, 2, 3, 4, 5 };
        //    for (int i = items.Count - 1; i >= 0; i--)
        //    {
        //        tempList.Add(items[i]);
        //    }
        //    items.Clear();
        //    items.AddRange(tempList);
        //}
    }
}
