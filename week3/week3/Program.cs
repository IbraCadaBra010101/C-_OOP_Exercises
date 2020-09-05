using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            // RemoveAllNegativeOccurences();
            // ConcatenateIndexWise();
            // ReverseList();
            // FindLengthOfWords();
            CheckingCommonMembers();
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
        #region  reversingList 

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


        #endregion
        #region FindLengthOfWords
        //static void FindLengthOfWords()
        //{
        //    List<string> words = new List<string>()
        //    {
        //        "The", "quick", "brown", "fox", "jumps",
        //        "over", "the", "lazy", "dog"
        //    };
        //    Console.WriteLine("Please enter the length of the word you're interested in finding!");
        //    int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine("The following words are {0} characters long: ", n);
        //    for (int i = 0; i < words.Count; i++)
        //    {
        //        if (words[i].Length > n)
        //        {
        //            Console.WriteLine(words[i]);
        //        }
        //    }
        //}


        #endregion

        #region  CheckingCommonMembers

        static void CheckingCommonMembers()
        {
            List<int> l1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> l2 = new List<int>() { 0, 0, 0, 1, 0 };
            int commonAmount = 0;

            for (int i = 0; i < l1.Count; i++)
            {
                for (int j = 0; j < l2.Count; j++)
                {
                    if (l1[i] == l2[j])
                    {
                        commonAmount++;
                    }
                }
            }

            if (commonAmount > 0)
            {
                Console.WriteLine("There are {0} shared members", commonAmount);
            }
            else
            {
                Console.WriteLine("There are no shared members!");
            }
        }

        #endregion

    }
}
