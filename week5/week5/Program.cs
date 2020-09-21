using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        #region create and write file 

        // Class exercises
        // File Exercises 

        // static void CreateFile()
        //{
        //    var filePath = @"C:\oop_csharp\exercises\week4\files_exercises/testFile.json";
        //    var fileText = "Hello World"; 
        //    File.WriteAllText(filePath, fileText);
        //}

        #endregion
        #region read from file

        //static void ReadFromFile()
        //{
        //    var path = @"C:\oop_csharp\exercises\week4\files_exercises/test.txt";
        //    var text = File.ReadAllText(path);
        //    Console.WriteLine(text);
        //}

        #endregion
        #region read and print on single line
        //static void ReadAndPrintOnSingleLine()
        //{
        //    var path = @"C:\oop_csharp\exercises\week4\files_exercises/test.txt";
        //    var text = File.ReadAllLines(path);
        //    foreach (var word in text)
        //        Console.Write(word + " ");
        //}
        #endregion
        #region read n lines from a file

        //static void ReadNumberOfLines()
        //{
        //    Console.WriteLine("Enter how many lines you would like to read?");
        //    var howManyLinesToReadInput = int.Parse(Console.ReadLine());
        //    var path = @"C:\oop_csharp\exercises\week4\files_exercises/test.txt";
        //    var text = File.ReadAllLines(path);
        //    for (var i = 0; i < howManyLinesToReadInput; i++)
        //    {
        //        Console.WriteLine(text[i]);
        //    }
        //}

        #endregion
        #region how many lines is in the file

        //static void HowManyLines()
        //{
        //    var path = @"C:\oop_csharp\exercises\week4\files_exercises/test.txt";
        //    var text = File.ReadAllLines(path);
        //    Console.WriteLine(text.Length);
        //}

        #endregion
        #region Logging actions

        //static void ReadInputAndWriteToLog()
        //{
        //    Console.WriteLine("Enter some text");
        //    var path = @"C:\oop_csharp\exercises\week4\files_exercises/log.txt";
        //    var input = Console.ReadLine();
        //    var stringFormat = $"{DateTime.Now.ToString()} Log: user entered {input} {Environment.NewLine}";
        //    File.AppendAllText(path, stringFormat);
        //}

        #endregion
        #region Word frequency in file

        static void WordFrequencyInFile()
        {
            const string path = "words.txt";
            var textAsString = File.ReadAllText(path);
            char[] delimeter = { '.', '!', '?', ',', '(', ')', '\t', '\n', '\r', ' ', '\0' };
            var textAsArray = textAsString.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
            var frequencyDictionary = new Dictionary<string, int>();
            foreach (var word in textAsArray)
            {
                var amountOfMultipleWords = 1;
                if (frequencyDictionary.ContainsKey(word))
                {
                    frequencyDictionary[word]++;
                }
                else
                {
                    frequencyDictionary.Add(word, amountOfMultipleWords);
                }
            }

            var sortedFrequencyDict = from entry in frequencyDictionary orderby entry.Value descending select entry;
 
            foreach (var frequency in sortedFrequencyDict)
            {
                Console.WriteLine($"({frequency.Key}) ({frequency.Value})");
            }
        }

        #endregion
    }
}