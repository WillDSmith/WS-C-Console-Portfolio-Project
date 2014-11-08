// Portfolio Program
// Programmer: Willie D Smith
// 05/12/2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillSmithCSharpConsoleProjectsPortfolio
{
    public class Jumble
    {
        private string[] aryWords = { "microsoft", "google", "apple", "programming", "android", "wp8", "xcode", "appstore", "google_play" };
        private char[] displayWord;
        private string hiddenWord;

        // Default Constructor
        public Jumble()
        {
            GenerateRandomWord();
        }

        public string GetHiddenWord()
        {
            return hiddenWord;
        }

        public string DisplayScrambledWord()
        {
            string scrambled = null;
            ScrambleWord();

            for (int i = 0; i < displayWord.Length; i++)
                scrambled = scrambled + displayWord[i];

            return scrambled;
        }

        public void ScrambleWord()
        {
            int random;
            char temp;
            Random randObj = new Random();

            displayWord = new char[hiddenWord.Length];  //initializing array

            for (int i = 0; i < hiddenWord.Length; i++)
            {
                do
                    random = randObj.Next(hiddenWord.Length);
                while (displayWord[random] != 0);

                temp = hiddenWord[i];

                displayWord[random] = temp;
            }
        }

        public void GenerateRandomWord()
        {
            int number = 0;

            Random generator = new Random();
            number = generator.Next(aryWords.Length);
            hiddenWord = aryWords[number];
        }

        public bool CompareString(string answer)
        {
            bool finalAnswer;

            if (answer == hiddenWord)
            {
                finalAnswer = true;
            }
            else
            {
                finalAnswer = false;
            }

            return
                finalAnswer;
        }
    }
}
