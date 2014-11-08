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
    class Portfolio
    {
        public void MainMenu()
        {
            int selection = 0;

            while (selection != 8)
            {
                Console.WriteLine("");
                DisplayMenu();
                selection = PromptForInt("Select a Menu Option: ");
                ProcessMenu(selection);
            }

            Console.ReadLine();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Will Smith's Semester Assignments");
            Console.WriteLine("");
            Console.WriteLine("1. Baseball Player");
            Console.WriteLine("2. Jumble Game");
            Console.WriteLine("3. Student Study hours");
            Console.WriteLine("4. Election App");
            Console.WriteLine("5. Farmer Game");
            Console.WriteLine("6. Tic Tac Toe V.1.0");
            Console.WriteLine("7. Hood Talk Trivia Game");
            Console.WriteLine("8. Exit\n");
        }

        public int ProcessMenu(int choice)
        {
            int value = 0;

            switch (choice)
            {
                case 1: //Baseball Player Program
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n********************************************");
                    Console.WriteLine("ASSIGNMENT #1: Baseball Player");
                    Console.WriteLine("********************************************");
                    Console.ResetColor();
                    BaseballPlayerMain myBPlayer = new BaseballPlayerMain();
                    myBPlayer.Main();
                    break;
                case 2: // Jumble Game
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n********************************************");
                    Console.WriteLine("ASSIGNMENT #2: Jumble Game");
                    Console.WriteLine("********************************************");
                    Console.ResetColor();
                    JumbleUI jumbleInterface = new JumbleUI();
                    jumbleInterface.PlayAgain();
                    break;
                case 3: // Student Study Hours
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n********************************************");
                    Console.WriteLine("ASSIGNMENT #3: Student Study Hours");
                    Console.WriteLine("********************************************");
                    Console.ResetColor();
                    StudentUI studentInterface = new StudentUI();
                    studentInterface.MainMethod();
                    break;
                case 4: // Election App
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n********************************************");
                    Console.WriteLine("ASSIGNMENT #4: Election App");
                    Console.WriteLine("********************************************");
                    Console.ResetColor();
                    ElectionUI electionInterface = new ElectionUI();
                    electionInterface.MainMethod();
                    break;
                case 5: // Farmer Game App
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n********************************************");
                    Console.WriteLine("ASSIGNMENT #5: Farmer Game");
                    Console.WriteLine("********************************************");
                    Console.ResetColor();
                    FarmerGameUI farmerInterface = new FarmerGameUI();
                    farmerInterface.Play();
                    break;
                case 6: // Tic Tac Toe Version 1.0 App
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n********************************************");
                    Console.WriteLine("ASSIGNMENT #6: Tic Tac Toe Version 1.0");
                    Console.WriteLine("********************************************");
                    Console.ResetColor();
                    Game myGame = new Game();
                    myGame.PlayAgain();
                    break;
                case 7: // Hood Talk Trivia Game App
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n********************************************");
                    Console.WriteLine("ASSIGNMENT #7: Hood Talk Trivia");
                    Console.WriteLine("********************************************");
                    Console.ResetColor();
                    HoodTalkTriviaGame htGame = new HoodTalkTriviaGame();
                    htGame.PlayAgain();
                    break;
                case 8: //exit
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nThat is it.... Exiting the application");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please choose an option 1 - 8 ... try again.\n");
                    Console.ResetColor();
                    break;
            }

            return value;
        }


        public int PromptForInt(string prompt)
        {
            int value;
            string inputValue;
            bool result;

            Console.Write(prompt);

            inputValue = Console.ReadLine();
            result = int.TryParse(inputValue, out value);

            return value;
        }

    }
}
