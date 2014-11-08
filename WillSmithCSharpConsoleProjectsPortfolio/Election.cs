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
    class Election
    {
        const int NUMCANDIDATES = 5;

        private string[] candidatesNames = new string[NUMCANDIDATES];
        private int[] votes = new int[NUMCANDIDATES];

        public Election()
        {
        }
        public Election(string[] nameNames, int[] numVotes)
        {
            ;
            for (int i = 0; i < candidatesNames.Length; i++)
            {
                candidatesNames[i] = "";
            }

            for (int i = 0; i < votes.Length; i++)
            {
                votes[i] = 0;
            }
        }


        public int NumberofCandidates
        {
            get { return NUMCANDIDATES; }
        }

        public void SetCandidateNames(string name, int index)
        {
            candidatesNames[index] = name;
        }

        public string GetCandidateName(int index)
        {
            return candidatesNames[index];
        }

        public void SetCandidateVotes(int vote, int index)
        {
            votes[index] = vote;
        }

        public int GetCandidateVotes(int index)
        {
            return votes[index];
        }

        public float GetTotalVotes()
        {
            float total = 0;

            for (int i = 0; i < votes.Length; i++)
            {
                total += GetCandidateVotes(i);
            }
            return total;
        }

        public int FindWinner()
        {
            int maximum = votes.Max();

            int winner = Array.IndexOf(votes, maximum);

            return winner;

        }

    }
}
