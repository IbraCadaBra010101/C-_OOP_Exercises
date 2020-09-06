using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;

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
            // CheckingCommonMembers();
            // DeclareDictionary();
            // AddMissingKey();
            // removeFalseKey();
            // PrintSumOfDictionary();
            // readKeyFromUser();
            // CountLettersInString();
            // CountPotentialGain();
            // CountPotentialGainNewDataStructure();
        }
        // LIST EXERCISES
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

        //static void CheckingCommonMembers()
        //{
        //    List<int> l1 = new List<int>() { 1, 2, 3, 4, 5 };
        //    List<int> l2 = new List<int>() { 0, 0, 0, 1, 0 };
        //    int commonAmount = 0;

        //    for (int i = 0; i < l1.Count; i++)
        //    {
        //        for (int j = 0; j < l2.Count; j++)
        //        {
        //            if (l1[i] == l2[j])
        //            {
        //                commonAmount++;
        //            }
        //        }
        //    }

        //    if (commonAmount > 0)
        //    {
        //        Console.WriteLine("There are {0} shared members", commonAmount);
        //    }
        //    else
        //    {
        //        Console.WriteLine("There are no shared members!");
        //    }
        //}

        #endregion



        //DICTIONARY EXERCISES 

        #region DeclareDictionary

        //static void DeclareDictionary()
        //{
        //    //Dictionary<string, string> me = new Dictionary<string, string>() { { "Name", "Jim" }, { "age", "10" } };
        //    //foreach (var el in me)
        //    //{
        //    //    Console.WriteLine("Keys:{0}\nValues{1}", el.Key, el.Value);

        //    //}
        //}


        #endregion
        #region AddMissingKey
        //static void AddMissingKey()
        //{
        //    Dictionary<string, string> person = new Dictionary<string, string>();
        //    person.Add("name","Jennifer");

        //    foreach (var pair in person )
        //    {
        //        Console.WriteLine(pair);
        //        Console.WriteLine(pair.Value);
        //        Console.WriteLine(pair.Key);
        //    }
        //}
        #endregion
        #region RemoveFalseKey
        //static void removeFalseKey()
        //{
        //    Dictionary<string, string> myDictionary = new Dictionary<string, string>() { { "name", "Foo Bar" }, { "age", "10" }, { "foo", "bar" } };

        //    myDictionary.Remove("foo");
        //    foreach (var pair in myDictionary)
        //    {
        //        Console.WriteLine(pair.Key + " " + pair.Value);
        //    }
        //}

        #endregion
        #region PrintSumOfDictionary

        //static void PrintSumOfDictionary()
        //{
        //    Dictionary<string, int> myNumsDictionary = new Dictionary<string, int>()
        //    {
        //        {"data1", 5}, {"data2", 1}, {"data3", 122}
        //    };
        //    int sum = 0;
        //    foreach (var pair in myNumsDictionary)
        //    {
        //        sum += pair.Value;
        //    }
        //    Console.WriteLine(sum);
        //}

        #endregion
        #region ReadKey

        //static void readKeyFromUser()
        //{
        //    string usersKey = Console.ReadLine();
        //    Dictionary<string, string> myDictionary = new Dictionary<string, string>()
        //    {
        //        {"name", "Foo Bar"}, {"age", "10"}
        //    };
        //    int amountOfKeysFound = 0;

        //    foreach (var pair in myDictionary)
        //    {
        //        if (pair.Key.Contains(usersKey.ToLower()))
        //        {
        //            Console.WriteLine(pair.Value);
        //            amountOfKeysFound++;
        //        }
        //    }

        //    if (amountOfKeysFound == 0)
        //    {
        //        Console.WriteLine("The provided key was not found!");
        //    }
        //}

        #endregion
        #region CountLettersInString

        //static void CountLettersInString()
        //{
        //    var randomString = "w3resource";
        //    Dictionary<char, int> myDictionary = new Dictionary<char, int>();

        //    for (int i = 0; i < randomString.Length; i++)
        //    {
        //        if (myDictionary.ContainsKey(randomString[i]))
        //        {
        //            myDictionary[randomString[i]]++;
        //        }
        //        else
        //        {
        //            myDictionary.Add(randomString[i], 1);
        //        }
        //    }
        //}

        #endregion
        #region CountPotentialGain

        //static void CountPotentialGain()
        //{
        //    Dictionary<string, double> itemPrices = new Dictionary<string, double>()
        //    {
        //        {"banana", 4}, {"apple", 2},  {"orange", 1.5},  {"pear", 3}
        //    };
        //    Dictionary<string, int> amountInStock = new Dictionary<string, int>()
        //    {
        //        {"banana", 10}, {"apple", 0},  {"orange", 32},  {"pear", 15}
        //    };

        //    double sumOfPrices = 0;

        //    for (var i = 0; i < itemPrices.Count; i++)
        //    {
        //        sumOfPrices += amountInStock.ElementAt(i).Value * itemPrices.ElementAt(i).Value;
        //    }
        //    Console.WriteLine("Money in store {0}", sumOfPrices);
        //}

        #endregion
        #region Countpotentialgainnewdatastructure

        //static void CountPotentialGainNewDataStructure()
        //{
        //    Dictionary<string, Dictionary<double, int>> productsDictionary = new Dictionary<string, Dictionary<double, int>>()
        //    {
        //        {"banana", new Dictionary<double, int>(){{4,10}}},
        //        {"apple", new Dictionary<double, int>(){{2,5}}},
        //        {"orange", new Dictionary<double, int>(){{1.5,16}}},
        //        {"pear", new Dictionary<double, int>(){{3,15}}},
        //    };
        //    double expectedGain = 0;
        //    foreach (var product in productsDictionary)
        //    {
        //        foreach (var priceAndAmount in product.Value)
        //        {
        //            expectedGain += priceAndAmount.Value * priceAndAmount.Key;
        //        }
        //    } 
        //    Console.WriteLine(expectedGain);
        //}
        #endregion
    }
}
