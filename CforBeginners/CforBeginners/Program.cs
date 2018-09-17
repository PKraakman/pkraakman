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

            var mywords = mytext.Split(' ');

            Console.WriteLine(mytext);
            Console.WriteLine("number of words: " + mywords.Length);

            var longestWord = "";

            foreach(var word in mywords)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            Console.WriteLine("longest word: " + longestWord);
        }   
    }
}
