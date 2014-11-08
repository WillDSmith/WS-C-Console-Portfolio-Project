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
    class JumbleUI
    {
        Jumble gameWord = new Jumble();
        String response = "Y";

        // Display Welcome heading
        public void DisplayWelcome()
        {
            string welcome = "****************************************************************\n" +
                         "*         Welcome To The Jumble - Word UnSrammble Game         *\n" +
                         "*    Try to unscramble the letters to make the hidden Word.    *\n" +
                         "*                  Created By: Willie D Smith                  *\n" +
                         "****************************************************************\n";
            Console.WriteLine(welcome);
        }

        public void PlayAgain()
        {
            do
            {
                Play();
                Console.Write("\nDo you want to try again? Enter (Y)es or (N)o ");
                response = Console.ReadLine();
                if (response.Length > 0)
                    response = response.Substring(0, 1);
                response = response.ToUpper();
                Console.WriteLine();
            }
            while (response == "Y");
        }
        public void Play()
        {
            bool result;

            //DisplayWelcome();
            gameWord.GenerateRandomWord();

            result = TakeGuess();

            if (result == true)
            {
                Console.WriteLine("\nYou win!");
                Console.Write("\nThe word was ");

                // Set Console text color to green for the hidden word
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(gameWord.GetHiddenWord());
                Console.ResetColor();
            }

            if (result == false)
            {
                Console.WriteLine("\nSorry, that is incorrect.");
            }
        }

        public bool TakeGuess()
        {
            bool finalAnswer;

            string testword = gameWord.DisplayScrambledWord();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(testword);
            Console.ResetColor();

            Console.Write("\nTake a guess: unscramble the word: ");
            string final = Console.ReadLine();
            finalAnswer = gameWord.CompareString(final);

            return finalAnswer;
        }
    }
}
