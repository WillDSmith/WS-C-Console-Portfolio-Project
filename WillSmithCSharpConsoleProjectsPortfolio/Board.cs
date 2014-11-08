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
    class Board
    {
        private const int NUM_SQUARES = 9;
        private const char EMPTY = ' ';
        private char[] m_Squares = new char[NUM_SQUARES];

        public Board()
        {
            Reset();
        }

        public int NumOfSquares
        {
            get { return NUM_SQUARES; }
        }

        public char[] PLAYINGBOARD  //return actual board.
        {
            get { return m_Squares; }
        }

        public void RecieveMove(char piece, int move)
        {
            m_Squares[move] = piece;
        }

        public bool IsFull()
        {
            bool full = true;
            int i = 0;

            while (full && i < NUM_SQUARES)
            {
                if (m_Squares[i] == EMPTY)
                {
                    full = false;
                }
                i++;

            }
            return full;
        }

        public bool IsLegalMove(int move)
        {
            bool result;

            if (move >= 0 && move < NUM_SQUARES && m_Squares[move] == EMPTY)
                result = true;
            else
                result = false;

            return result;

        }

        public void Reset()
        {
            for (int i = 0; i < NUM_SQUARES; ++i)
            {
                m_Squares[i] = EMPTY;
            }
        }

        public bool IsWinner(char piece)
        {
            bool winner = false;

            // Winning Across
            if (m_Squares[0] == piece && m_Squares[1] == piece && m_Squares[2] == piece)
                winner = true;
            if (m_Squares[3] == piece && m_Squares[4] == piece && m_Squares[5] == piece)
                winner = true;
            if (m_Squares[6] == piece && m_Squares[7] == piece && m_Squares[8] == piece)
                winner = true;

            // Winning Down
            if (m_Squares[0] == piece && m_Squares[3] == piece && m_Squares[6] == piece)
                winner = true;
            if (m_Squares[1] == piece && m_Squares[4] == piece && m_Squares[7] == piece)
                winner = true;
            if (m_Squares[2] == piece && m_Squares[5] == piece && m_Squares[8] == piece)
                winner = true;

            // Winning Diagonally
            if (m_Squares[0] == piece && m_Squares[4] == piece && m_Squares[8] == piece)
                winner = true;
            if (m_Squares[6] == piece && m_Squares[4] == piece && m_Squares[2] == piece)
                winner = true;

            return winner;
        }
    }
}
