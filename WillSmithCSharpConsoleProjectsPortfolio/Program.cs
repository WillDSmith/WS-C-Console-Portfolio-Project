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
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("Final Project - Portfolio");

            Portfolio wsPortfolio = new Portfolio();
            wsPortfolio.MainMenu();

            Console.ReadLine();
        }
    }
}
