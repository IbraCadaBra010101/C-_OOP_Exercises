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
           var caesarCiphered = CaesarCipher();
           Console.WriteLine(caesarCiphered);
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
        #region ScrambleWords

        //static string ScrambleWords()
        //{
        //    Console.WriteLine("Enter a word and it will get scrambled!");

        //    var userInput = Console.ReadLine();
        //    var random = new Random();
        //    var arrayOfChars = userInput.ToList();

        //    var listOfCharRandomized = new List<char>();

        //    while (arrayOfChars.Count > 0)
        //    {
        //        var randomIndexWithinRange = random.Next(arrayOfChars.Count - 1);
        //        var c = arrayOfChars[randomIndexWithinRange];
        //        listOfCharRandomized.Add(c);
        //        arrayOfChars.Remove(arrayOfChars[randomIndexWithinRange]);
        //    }
        //    var scrambled = new string(listOfCharRandomized.ToArray());
        //    return scrambled;
        //}

        //static string Shuffle()
        //{
        //    Console.WriteLine("Enter a word and it will get scrambled!");
        //    var userInput = Console.ReadLine();
        //    var randomIndex = new Random();
        //    var list = new SortedList<int, char>();
        //    foreach (var character in userInput)
        //    {
        //         list.Add(randomIndex.Next(), character);
        //    }

        //    return new string(list.Values.ToArray());
        //}
        #endregion
        #region Adding postfix

        //static string AddPostFix()
        //{
        //    Console.WriteLine("Enter a word with at least three characters");
        //    var userInput = Console.ReadLine();
        //    var alphabeticalCharactersOnly = Regex.IsMatch(userInput, @"^[a-zA-Z]+$");

        //    while (string.IsNullOrWhiteSpace(userInput) || !alphabeticalCharactersOnly || userInput.Length < 3)
        //    {  
        //        Console.WriteLine("Please enter a valid word using alphabetical characters with at least three characters");
        //        userInput = Console.ReadLine();
        //        alphabeticalCharactersOnly = Regex.IsMatch(userInput, @"^[a-zA-Z]+$");

        //    }
        //    var lyOrIn = userInput.Insert(userInput.Length, userInput.Substring(userInput.Length - 3) == "ing" ? "ly" : "ing");
        //    return lyOrIn;
        //}
        #endregion
        #region Longest word in string

        //static string LongestWordInSentence()
        //{
        //    var userSentence = Console.ReadLine();
        //    var longestWord = ""; 
        //    var wordsList = userSentence .Split(" ");
        //    foreach (var currentWord in wordsList)
        //    {
        //        longestWord = currentWord.Length > wordsList[0].Length ? currentWord : wordsList[0];  
        //    }
        //    return longestWord;
        //}

        #endregion
        #region Ceaser cipher

        //static string CaesarCipher()
        //{
        //    Console.WriteLine("Enter word to be caesar ciphered");
        //    var usersPassword = Console.ReadLine();
        //    Console.WriteLine("Enter shift direction and amount of shifts: \nex. shift [amount of steps] / [amount of steps] shift");
        //    var leftOrRightShift = Console.ReadLine();
        //    var listOfShiftLeftOrRight = leftOrRightShift.Split(" ");  
        //    var passwordToList = usersPassword.ToCharArray();
        //    List<char> caesarChars;
        //    if (listOfShiftLeftOrRight[0] == "shift")
        //    {
        //        var amountOfStep = int.Parse(listOfShiftLeftOrRight[1]) -1;
        //         caesarChars = passwordToList.Select(character => (char)((int)(character + amountOfStep))).ToList();
        //    }
        //    else
        //    {
        //        var amountOfStep = int.Parse(listOfShiftLeftOrRight[0]) - 1;
        //        caesarChars = passwordToList.Select(character => (char)((int)(character - amountOfStep))).ToList();
        //    }
        //    var caesarCipheredOutPut = new string(caesarChars.ToArray());
        //    return caesarCipheredOutPut;
        //}


        #endregion

    }



}
