using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;


namespace CforBeginners
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\ccode\testdata\testfile1.txt";
            var mytext = File.ReadAllText(path);

            string[] MyWords;
            MyWords = mytext.Split(' ');

            Console.WriteLine(mytext);
            Console.WriteLine("number of words: " + MyWords.Length);

            var longestWord = "";

            foreach(var word in MyWords)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            Console.WriteLine("longest word: " + longestWord);
        }   
    }
}
