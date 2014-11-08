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
    class BaseballPlayer
    {
        private double battingAvg;
        private string firstName;
        private string lastName;
        private string team;

        // Default Constructor
        public BaseballPlayer()
        {
            battingAvg = 0.0;
            firstName = "";
            lastName = "";
            team = "";
        }

        // Constructor with all data members
        public BaseballPlayer(double battingAvg, string firstName, string lastName, string team)
        {
            this.battingAvg = battingAvg;
            this.firstName = firstName;
            this.lastName = lastName;
            this.team = team;
        }

        public void SetBattingAvg(double battingAvg)
        {
            this.battingAvg = battingAvg;
        }

        public double GetBattingAvg()
        {
            return battingAvg;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetTeam(string team)
        {
            this.team = team;
        }

        public string GetTeam()
        {
            return team;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("First Name: " + this.GetFirstName() + "\nLast  Name: "
                + this.GetLastName() + "\nTeam: " + this.GetTeam() + "\nBatting Average: "
                + this.GetBattingAvg() + "\n");
        }


    }
}
