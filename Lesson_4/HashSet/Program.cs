using System;
using System.Collections.Generic;
using System.Linq;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static int wordsNumber = 10_000;

        string[] wordsArr = new string[wordsNumber];
        HashSet<string> wordsHash = new HashSet<string>();

        void GenerateWords()
        {
            int lettersInWord = 5;
            char[] letters = "QWERTASDFGZXCVBYUIOPHJKLNMqwertasdfgzxcvbyuiophjklnm".ToCharArray();

            Random random = new Random();

            for (int i = 1; i <= wordsNumber; i++)
            {
                string word = "";
                for (int j = 1; j < lettersInWord; j++)
                {
                    int LetterIndex = random.Next(0, letters.Length);

                    word += letters[LetterIndex];
                }
                wordsArr[i] = word;
                wordsHash.Add(word);
            }
        }

        bool IsArrayContains(string str)
        {
            return wordsArr.Any(n => n == str);
        }

        bool IsHashSetContains(string str)
        {
            return wordsHash.Contains(str);
        }
    }
}
