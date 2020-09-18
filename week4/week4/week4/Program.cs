using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace week4
{
    class Program
    {
        private static void Main(string[] args)
        {
        }

        #region Separate characters
        //static string PutCommasBetweenEachCharacter(string txt)
        //{
        //    char[] temp = txt.ToCharArray();
        //    return string.Join(",", temp);
        //}
        #endregion
        #region Count words

        //static int countWords(string txt)
        //{
        //    var wordsArray = txt.Split(" ");
        //    return wordsArray.Length;
        //}
        #endregion
        #region String contains substring
        static void CheckIfSubstringExists(string substring, string txt)
        {
            if (txt.ToLower().Contains(substring.ToLower()))
            {
                Console.WriteLine($"{substring} exists in substring");
            }
            else
            {
                Console.WriteLine($"{substring} does not exist in substring");
            }
        }
        #endregion
        #region switchCase

        //private static string UserInput()
        //{
        //    var userInputWord = Console.ReadLine();
        //    while (string.IsNullOrWhiteSpace(userInputWord) || int.TryParse(userInputWord, out var _))
        //    {
        //        Console.WriteLine("Error: enter a word"); 
        //        userInputWord = Console.ReadLine();
        //    }

        //    return userInputWord;
        //}

        //private static string SwitchCases(string text)
        //{
        //    var switchedCases = "";
        //    foreach (var character in text)
        //    {
        //        if (char.IsUpper(character))
        //        {
        //            switchedCases += char.ToLower(character);
        //        }
        //        else
        //        {
        //            switchedCases += char.ToUpper(character);
        //        }
        //    }
        //    return switchedCases;
        //}

        //static string SwitchCases(string text)
        //{
        //    var switchedCases = "";
        //    foreach (var character in text)
        //    {
        //        var asciiValue = (int)character;
        //        if (asciiValue >= 97 && asciiValue <= 122) //check if char is lowercase
        //        {
        //            switchedCases += (char)(character - 32); //make it uppercase
        //        }
        //        else if (asciiValue >= 65 && asciiValue <= 90) //check if it's uppercase
        //        {
        //            switchedCases += (char)(character + 32); //make it lowercase
        //        }
        //        else
        //        {
        //            throw new Exception("Character is not a letter");
        //        }
        //    }
        //    return switchedCases;
        //}
        #endregion
        #region Count substring

        //static int CountAmountOfSubString(string txt, string subTxt)
        //{
        //    var amountOfMatches = Regex.Matches(txt, subTxt).Count;
        //    return amountOfMatches;
        //}



        #endregion
        #region Equal ignore case

        //static string CompareToYes()
        //{
        //    var usersInput = Console.ReadLine();
        //    const string yes = "yes";

        //    var isYes = yes == usersInput.ToLower();
        //    var userMessage = isYes ? $"{usersInput} is equal to {yes}" : $"{usersInput} is not equal to {yes}";

        //    return userMessage;
        //}

        #endregion
        #region Read user details
        //private static void UserInputForm()
        //{
        //    Console.WriteLine("Write name, age, phone number use comma in between each detail!");
        //    var userInput = Console.ReadLine();
        //    var userInputArray = userInput.Split(",");
        //    Console.WriteLine($"$Name:{userInputArray[0]}");
        //    Console.WriteLine($"Age:{userInputArray[1]}");
        //    Console.WriteLine($"Phone number:{userInputArray[2]}");
        //}
        #endregion
        #region  Ends in with period
        //static void EndsWithPeriod()
        //{
        //    var userInput = Console.ReadLine();
        //    var isLastElementPeriod = userInput.ElementAt(userInput.Length - 1).Equals('.')
        //        ? $"{userInput} ends with a period"
        //        : $"{userInput} does not end with period";
        //    Console.WriteLine(isLastElementPeriod);
        //}
        #endregion



    }



}
