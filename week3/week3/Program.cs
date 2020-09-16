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
            //PrintHello();
            //var a = GetAndPrintAge();
            //Console.WriteLine(a);
            //Console.WriteLine(GetAndPrintAge());
            //var number1 = number();
            //var number2 = number();
            //var result =  CalcSum(number1, number2);
            //Console.WriteLine(result);
            //var first = FirstNameInput();
            //var second = SecondNameInput();
            //var wholeName = CombineNames(first);
            //Console.WriteLine(wholeName);
            //int num1 = UserInput("write first number");
            //int num2 = UserInput("write second number");
            //int num3 = UserInput("write third number");
            //var smallestNum = SmallestNumberOfTwoNumbers(SmallestNumberOfTwoNumbers(num1, num2), num3);
            //Console.WriteLine(smallestNum);
            //Console.WriteLine("Enter a statement!");
            //var userInput = Console.ReadLine();
            //var myBool = CheckBool(userInput);
            //Console.WriteLine(myBool);
            //Console.WriteLine("Hello");
            //var res = CheckBool(Console.ReadLine(), out var checker);
            //Console.WriteLine(res);
            //Console.WriteLine(checker);
            //Console.WriteLine("Write a valid number");
            //var a = int.TryParse(Console.ReadLine(), out var number);
            //Console.WriteLine(a);
            //Console.WriteLine(number);
            //Console.WriteLine("Hello, enter a number!");
            // int clampResult = clampToRange(Console.ReadLine());
            // Console.WriteLine(clampResult);
            //var weekDayString = WeekDay(ValidateInput());
            // Console.WriteLine(weekDayString);
            //var userAgeInSeconds = validateInput();
            //var age = YourAgeIndifferentPlanets(userAgeInSeconds);
            //foreach (var planet in age)
            //{
            //    Console.WriteLine($"Age in planet {planet.Key}: {planet.Value}");
            //}
            var res = FactorialOfNumber(5);
            Console.WriteLine(res);
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

        // Methods 

        #region hellofunction

        // static string PrintHello()
        //{
        //    Console.WriteLine("Hello function");
        //}

        #endregion
        #region Get name function
        //static string GetAndPrintAge()
        //{
        //    Console.WriteLine("Please enter your age!");
        //    var ageInput = int.Parse(Console.ReadLine());
        //    var message = $"User age is {ageInput} years old";
        //    return message;
        //}
        #endregion
        #region Calculate sum
        //static int number()
        //{
        //    Console.WriteLine("Write your number");
        //    var userInput = int.Parse(Console.ReadLine());
        //    return userInput;
        //}
        //static int CalcSum(int firsNum, int secondNum)
        //{
        //    var sum = firsNum + secondNum;
        //    return sum;
        //}



        #endregion
        #region combineNames 

        //Combine name
        //Write an app that reads first name and last name from the user and combines them if no last name
        //    was entered N:A should be used instead.Create a function that takes first name and last name as in 
        //parameter the default value of last name should be “N:A”. It should combine these values and return
        //the result.Remember to only call the function with a last name if one was given.
        //static string FirstNameInput()
        //{
        //    Console.WriteLine("Enter first name");
        //    string userInput = Console.ReadLine();
        //    return userInput;
        //}
        //static string SecondNameInput()
        //{
        //    Console.WriteLine("Enter second name");
        //    string userInput = Console.ReadLine();
        //    return userInput;
        //}
        //static string CombineNames(string firstName, string secondName = "N:A")
        //{
        //    return $"{firstName} {secondName}";
        //}
        #endregion
        #region smallestNumber/biggestnumber

        //Smallest method
        //Write an app that read three numbers from the user and returns the smallest of the three numbers.
        //    Write a function that only takes two integers as in parameters and returns the smallest of the in
        //parameters.
        //    Hint! To get the minimum of three numbers first find the minimum of two and then the minimum of
        //the result of the first function and the last number
        //Example data:
        //4
        //5
        //6
        //Example output:
        //6 is the largest number

        //static int UserInput(string message)
        //{
        //    Console.WriteLine(message);
        //    var numbInput = int.Parse(Console.ReadLine());
        //    return numbInput;
        //}

        //static int SmallestNumberOfTwoNumbers(int firstNum = 0, int secondNum = 0)
        //{
        //    return firstNum < secondNum ? firstNum : secondNum;
        //}

        //static int OnlyOneNumber(int num = 0)
        //{
        //    return num;
        //}
        #endregion
        #region checkbool 
        //Swedish bool parser
        //Write an app that converts input from the user in Swedish to a bool. Write a function that takes a
        //string as in parameter and returns a bool. The input string should be checked for the swedish words
        //    Ja, Sant, Nej, Falskt and if it matches any of these return the corresponding bool. If no match was
        //found print an error message and return False or throw an error(exception)
        //Example data:
        //Ja
        //    Example output:
        //True
        //    Example data:
        //Nej
        //    Example output:
        //False
        //    Example data:
        //Foo
        //    Example output:
        //Error can not convert “Foo” to Swedish bool
        //static bool CheckBool(string userInput, out bool outValue)
        //{


        //    outValue = false;
        //    switch (userInput)
        //    {
        //        case "nej":
        //        case "falsk":
        //            outValue = false;
        //            break;
        //        case "ja":
        //        case "sant":
        //            outValue = true;
        //            break;
        //        default:
        //            Console.WriteLine($"Could not parse {userInput}");
        //            break;
        //    }

        //    return outValue;
        //}

        #endregion
        #region clampToRange
        /*
         *Clamp to range Write an app that reads a number from
         * the user and ensures that it is in a range. Write a
         * function that takes a number as an input and clamps
         * that number to the range 0 – 20. Clamp meaning forcing
         * the value to be in the give range if for example the number -1
         * was give we would clamp to 0 if it were more than 20, we
         * would clamp to 20. Return the clamped value and print the result. 
                Example data: 
                26 
                Example output: 
                20 
                Example data: 
                -1 
                Example output 
                0 
                Example data: 
                5 
                Example output: 
         *
         */
        //static int clampToRange(string userInput)
        //{
        //    var userNumber = int.Parse(userInput);
        //    if (userNumber > 20)
        //    {
        //        userNumber = 20;
        //    }

        //    if (userNumber < 0)
        //    {
        //        userNumber = 0;
        //    }
        //    return userNumber;
        //}
        #endregion
        #region weekDay

        /**
         *  Write an app that reads a number from the user and returns the name of the day corresponding to
            that number 1 is Monday. Read number should be a function. Validate input from read number
            should be a function that returns true or false based on if the input is valid. Create a function that
            takes a number as a in parameter and returns the weekday as a string that is only called when input
            is valid. If input is not valid an error message should be printed
            Example data:
            1
            Example output:
            Monday
            Example data:
            10
            Example output:
            10 is not a valid input
         */
        //static int ValidateInput()
        //{
        //    Console.WriteLine("Write a number from 1 to 7 to get the corresponding week day!");
        //    var userInput = Console.ReadLine();
        //    int validNumber; 
        //    while (!(int.TryParse(userInput, out  validNumber)) || (validNumber > 7 || validNumber < 1))
        //    {
        //        Console.WriteLine("Invalid number. Write a number from 1 to 7");
        //        userInput = Console.ReadLine();
        //    }
        //    return validNumber;
        //}
        //static string WeekDay(int userNumber)
        //{
        //    var day = "";
        //    switch (userNumber)
        //    {
        //        case 1:
        //            day = "Monday";
        //            return day;
        //        case 2:
        //            day = "Tuesday";
        //            return day;

        //        case 3:
        //            day = "Wednesday";
        //            return day;

        //        case 4:
        //            day = "Thursday";
        //            return day;
        //        case 5:
        //            day = "Friday";
        //            return day;
        //        case 6:
        //            day = "Saturday";
        //            return day;
        //        case 7:
        //            day = "Sunday";
        //            return day;

        //    }

        //    return day;
        //}

        #endregion
        #region Age on planets

        //static double validateInput()
        //{
        //    string userInput;
        //    double userInputNumber;
        //    do
        //    {
        //        Console.WriteLine("Enter your age in seconds!");
        //        userInput = Console.ReadLine();
        //    } while (!double.TryParse(userInput, out userInputNumber));

        //    return userInputNumber;
        //}

        //static Dictionary<string, double> YourAgeIndifferentPlanets(double ageInSeconds)
        //{

        //    const double secondsPerYear = 365.25 * 24 * 60 * 60;
        //    var orbitPeriod = new Dictionary<string, double>()
        //    {
        //        {"Earth",  1},
        //        {"Mercury",   0.2408467},
        //        {"Venus",  0.61519726},
        //        {"Mars", 1.8808158 }
        //    };
        //    var ageInDifferentPlanets = new Dictionary<string, double>() { };

        //    foreach (var (key, value) in orbitPeriod)
        //    {
        //        var secondsInYear = value * secondsPerYear;
        //        var ageInPlanet = ageInSeconds / secondsInYear;
        //        ageInDifferentPlanets.Add(key, ageInPlanet);
        //    }

        //    return ageInDifferentPlanets;
        //}

        #endregion
        #region factorialofN

        //static int FactorialOfNumber(int n)
        //{

        //    if (n > 0)
        //        return n * FactorialOfNumber(n - 1);
        //    return 1;


        //}
        #endregion
    }
}

