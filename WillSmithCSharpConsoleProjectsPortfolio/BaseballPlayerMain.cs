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
    class BaseballPlayerMain
    {
        public void Main()
        {

            BaseballPlayer playerOne = new BaseballPlayer();
            playerOne.SetFirstName("Chris");
            playerOne.SetLastName("Johnson");
            playerOne.SetTeam("Atlanta Braves");
            playerOne.SetBattingAvg(.321);

            BaseballPlayer playerTwo = new BaseballPlayer();
            playerTwo.SetFirstName("Freddie");
            playerTwo.SetLastName("Freeman");
            playerTwo.SetTeam("Atlanta Braves");
            playerTwo.SetBattingAvg(.319);

            //Console.Clear();
            playerOne.DisplayInfo();
            playerTwo.DisplayInfo();

            // Use this to prevent the program from immediately closing when it is running 
            // otherwise when running without debugging the program will run until a key is 
            // pressed to stop it.
            Console.ReadKey();



        }
    }
}
