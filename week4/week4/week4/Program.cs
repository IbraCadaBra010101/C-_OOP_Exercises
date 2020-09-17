using System;
using System.Collections.Generic;
using System.Linq;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIfSubstringExists("text", "tests exists in the string");

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
    }

}
