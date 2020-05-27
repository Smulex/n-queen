using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Queen
{
    class Program
    {
         static Solver solver = new Solver();
        static void Main(string[] args)
        {

            Console.Write("This is the solver to the N queen problem!\n\nType the N value (4-10): ");

            try
            {
                solver.n = Convert.ToInt32(Console.ReadLine());
                if (solver.n > 10)
                {
                    solver.n = 10;
                }
            }
            catch (Exception)
            {
                solver.n = 8;
            }

            Console.WriteLine(solver.PlaceQueens()); 

            Console.ReadKey();
        }

        public void printSolution(int[,] gameBoard)
        {
            Console.WriteLine("Solution number: {0}", solver.solutionNumber++);
            for (int i = 0; i < solver.n; i++)
            {
                for (int j = 0; j < solver.n; j++)
                {
                    Console.Write(" {0}", gameBoard[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
