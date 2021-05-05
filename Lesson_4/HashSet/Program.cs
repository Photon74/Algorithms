using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSet
{
    public class Program
    {
        static int wordsNumber = 10_000;

        public static string[] wordsArr = new string[wordsNumber];
        public static HashSet<string> wordsHash = new HashSet<string>();
        static void Main(string[] args)
        {
            for (int i = 0; i < wordsNumber; i++)
            {
                wordsArr[i] = GenerateWord(lettersInWord: 5);
                wordsHash.Add(GenerateWord(lettersInWord: 5));
            }
            
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }

        public class BechmarkClass
        {
            string stringForSearching = GenerateWord(lettersInWord: 5);

            [Benchmark]
            public bool TestSearchInArray()
            {
                return wordsArr.Any(n => n == stringForSearching);
            }

            [Benchmark]
            public bool TestSearchInHashSet()
            {
                return wordsHash.Contains(stringForSearching);
            }
        }        


        public static string GenerateWord(int lettersInWord)
        {
            char[] letters = "QWERTASDFGZXCVBYUIOPHJKLNMqwertasdfgzxcvbyuiophjklnm".ToCharArray();

            Random random = new Random();

            string word = "";
            for (int j = 1; j < lettersInWord; j++)
            {
                int LetterIndex = random.Next(0, letters.Length);

                word += letters[LetterIndex];
            }
            return word;
        }
    }
}
