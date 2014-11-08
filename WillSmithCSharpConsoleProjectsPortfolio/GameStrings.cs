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
    class GameStrings
    {
        // Display River
        public void RiverString()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
        }

        public void HoodTalkString()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("########################################################################\n");
            Console.Write("");
            Console.ResetColor();
            Console.Write("                       Welcome to Hood Talk Trivia \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("Hood Talk Trivia is the only trivia game that tests your knowledge of \n" +
                              "hood topics. Are you a king/queen of the hood?  The questions will start \n" +
                              "off easy and increase difficulty as you progress.  Gain points by getting \n" +
                              "as many correct answers as you can. In this version each correct answer \n" +
                              "is worth 20 points and your score is tallied after completion of each \n" +
                              "round.");

            Console.WriteLine("\n");
            Console.WriteLine("Prepare yourself. Good luck and “Stay Hood”.\n");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("########################################################################\n\n");
            Console.ResetColor();
        }
    }
}
