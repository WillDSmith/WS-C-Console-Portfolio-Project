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
    class Player
    {
        const int NUM_PIECES = 2;

        static int current = 0;
        //private char[] PIECES = new char[NUM_PIECES] {'X', 'O'};
        private char[] PIECES = { 'X', 'O' };
        private char m_piece;

        public Player()
        {
            m_piece = PIECES[current];
            current = (current + 1) % NUM_PIECES;
        }

        public char PIECE
        {
            get { return m_piece; }
        }

        public void MakeMove(ref Board aBoard, int move)
        {
            aBoard.RecieveMove(m_piece, move);
        }
    }
}
