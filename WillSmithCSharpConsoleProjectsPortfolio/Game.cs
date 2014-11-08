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
    class Game
    {
        int current = 0;
        const int NUM_PLAYERS = 2;
        const int FIRST = 0;
        const int SECOND = 1;
        Player[] players = new Player[NUM_PLAYERS];
        Board theBoard = new Board();
        String response = "Y";

        public void PlayAgain()
        {
            do
            {
                Play();
                Console.WriteLine("\nDo you want to try again? Enter (Y)es or (N)o");
                response = Console.ReadLine();
                if (response.Length > 0)
                    response = response.Substring(0, 1);
                response = response.ToUpper();
            }
            while (response == "Y");

        }

        void Play()
        {
            Console.SetWindowSize(80, 50);

            players[0] = new Player();

            // Make sure the game board is empty and ready for game play
            theBoard.Reset();

            // Make sure the current player is = X for the start of any new game
            current = 0;

            Console.WriteLine("First piece " + players[0].PIECE + "\n");

            players[1] = new Player();
            Console.WriteLine("Second piece " + players[1].PIECE + "\n");
            int move;

            while (IsPlaying() == true)   // Play until board full
            {

                DisplayGrid();
                Console.WriteLine("");
                move = PromptforMove(players[current].PIECE);
                Console.WriteLine("");
                while (theBoard.IsLegalMove(move) == false)
                {
                    Console.WriteLine("Not valid move");
                    move = PromptforMove(players[current].PIECE);
                }

                players[current].MakeMove(ref theBoard, move);

                NextPlayer();
            }

            // Display the grid a final time to get last piece on board before calling AnnounceWinner()
            DisplayGrid();

            // Announce the winner of the game
            AnnounceWinner();

        }

        void AnnounceWinner()
        {
            Console.WriteLine("\nThe Raging battle has come to an end.");
            Console.WriteLine();

            if (IsTie())
            {
                Console.WriteLine("\nSadly, no player emerged victorious.");
                Console.WriteLine();
            }
            else
            {
                if (theBoard.IsWinner(players[FIRST].PIECE))
                {
                    Console.WriteLine("The winner of this climatic confrontation is Player " + players[FIRST].PIECE);
                }
                else
                {
                    Console.WriteLine("The winner of this climatic confrontation is Player " + players[SECOND].PIECE);
                }
            }
        }

        bool IsPlaying()
        {
            return (!theBoard.IsFull() && !theBoard.IsWinner(players[FIRST].PIECE) && !theBoard.IsWinner(players[SECOND].PIECE));
        }

        bool IsTie()
        {
            return (theBoard.IsFull() && !theBoard.IsWinner(players[FIRST].PIECE) && !theBoard.IsWinner(players[SECOND].PIECE));
        }

        void NextPlayer()
        {
            // current = (current + 1) % NUM_PLAYERS;
            if (current == 0)
                current = 1;
            else
                current = 0;
        }
        void DisplayGrid()
        {
            int numOfElements;
            numOfElements = theBoard.NumOfSquares;

            char[] thegrid = new char[numOfElements];
            thegrid = theBoard.PLAYINGBOARD;

            Console.WriteLine(" 0 | 1 | 2\t{0} | {1} | {2} ", thegrid[0], thegrid[1], thegrid[2]);
            Console.WriteLine(" ---------\t---------");
            Console.WriteLine(" 3 | 4 | 5\t{0} | {1} | {2} ", thegrid[3], thegrid[4], thegrid[5]);
            Console.WriteLine(" ---------\t---------");
            Console.WriteLine(" 6 | 7 | 8\t{0} | {1} | {2} ", thegrid[6], thegrid[7], thegrid[8]);

        }
        public int PromptforMove(char piece)
        {
            int move;

            Console.Write("Make a Move player {0}:>> ", piece);
            int.TryParse(Console.ReadLine(), out move);

            return move;
        }
    }
}
