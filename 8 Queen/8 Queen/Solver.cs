using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Queen
{
    class Solver
    {
        public int n;
        public int solutionNumber = 1;

        public string PlaceQueens()
        {
            int[,] gameBoard = new int[n, n];

            if (AllPlacedCheck(gameBoard, 0) == false)
            {
                return "Solution not found.";
            }
            return "Solution found.";
        }
        private bool PlaceOrNotPlace(int[,] board, int row, int column)
        {
            int i, j;

            for (i = 0; i < column; i++)
            {
                if (board[row, i] == 1)
                {
                    return false;
                }
            }
            for (i = row, j = column; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }
            for (i = row, j = column; j >= 0 && i < n; i++, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }
            return true;
        }
        private bool AllPlacedCheck(int[,] gameBoard, int column)
        {
            Program program = new Program();
            if (column == n)
            {
                program.printSolution(gameBoard);
                return true;
            }

            bool result = false;
            for (int i = 0; i < n; i++)
            {
                if (PlaceOrNotPlace(gameBoard, i, column))
                {
                    gameBoard[i, column] = 1;

                    result = AllPlacedCheck(gameBoard, column + 1) || result;

                    gameBoard[i, column] = 0;
                }
            }
            return result;
        }
    }
}
