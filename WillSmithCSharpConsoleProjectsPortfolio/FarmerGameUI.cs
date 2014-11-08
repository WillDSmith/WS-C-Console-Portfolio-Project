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
    class FarmerGameUI
    {
        FarmerGame myGame;
        GameStrings myGameStrings;

        public void Play()
        {
            myGame = new FarmerGame();
            myGameStrings = new GameStrings();

            Console.SetWindowSize(80, 50);

            while (myGame.GameOver() != true)
            {
                DisplayGameState();
                ProcessChoice();
            }

            PlayAgain();

        }

        public void DisplayGameState()
        {
            Console.WriteLine("Farmer is on the " + myGame.Farmer + " bank\n");
            DisplayNorthBank();
            DisplayRiver();
            DisplaySouthBank();
        }

        public void DisplayRiver()
        {
            myGameStrings.RiverString();
        }

        public void DisplayNorthBank()
        {
            List<string> north;
            north = myGame.NorthBank;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("############  North Bank  #############");
            Console.ResetColor();
            foreach (string value in north)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine();

        }

        public void DisplaySouthBank()
        {
            List<string> south;
            south = myGame.SouthBank;

            foreach (string value in south)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("############  South Bank  #############");
            Console.ResetColor();
        }

        public void ProcessChoice()
        {
            string receivedChoice;
            bool flag = true;

            receivedChoice = PromptForMove();
            myGame.Move(receivedChoice);

            if (myGame.DetermineWin() == flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Game Over!!!!! You Win");
                Console.ResetColor();
            }
            else if (myGame.GameOver() == flag)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over!!! the animal ate the food");
                Console.ResetColor();
            }

        }
        public string PromptForMove()
        {
            string choice;

            Console.Write("\nWhat would you like to move? ");
            choice = Console.ReadLine();
            Console.WriteLine("\n");

            return choice;
        }

        public void PlayAgain()
        {
            string choice;
            string answer = "yes";

            Console.Write("\nWould you like to play again : (Enter yes/no)");
            choice = Console.ReadLine();

            if (choice == answer)
            {
                Play();
            }
            else if (choice != answer)
            {
                Environment.Exit(0);
            }

        }
    }
}
