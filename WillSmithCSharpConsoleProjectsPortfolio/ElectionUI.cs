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
    class ElectionUI
    {
        Election theElection;
        string name;
        int vote;

        public void MainMethod()
        {
            theElection = new Election();

            for (int i = 0; i < theElection.NumberofCandidates; i++)
            {
                PromptForString();
                theElection.SetCandidateNames(name, i);

                PromptForInt();
                theElection.SetCandidateVotes(vote, i);
            }

            DisplayResults();
        }

        public void PromptForString()
        {
            Console.Write("Enter candidates name: ");
            name = Console.ReadLine();
        }
        public void PromptForInt()
        {
            string value;
            Console.Write("Enter number of votes for " + name + ": ");
            value = Console.ReadLine();
            vote = int.Parse(value);

        }
        public void DisplayResults()
        {

            float totalVotes = theElection.GetTotalVotes();
            float percentage = 0;

            Console.WriteLine(totalVotes);
            Console.WriteLine("\n################################");
            for (int i = 0; i < theElection.NumberofCandidates; i++)
            {
                percentage = (theElection.GetCandidateVotes(i) / totalVotes) * 100;
                Console.WriteLine(theElection.GetCandidateName(i) + "\t\t" + theElection.GetCandidateVotes(i) +
                    "\t" + percentage.ToString(".00") + " %");
            }

            int win = theElection.FindWinner();
            Console.WriteLine("\nThe Winner is " + theElection.GetCandidateName(win));
        }
    }
}
