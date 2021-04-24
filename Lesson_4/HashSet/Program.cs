using System;

namespace HashSet
{
    class Program
    {
        
        void GenerateWords()
        {
            int wordsNumber = 10_000;
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
                 
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
