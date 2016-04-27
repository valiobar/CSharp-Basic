using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_19.Spiral_Matrix
{
    class Program
    {


        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write( "{0:00} ",matrix[i, j] );
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix size:");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            FillMatrix(0, 0, matrix);
            PrintMatrix(matrix);
            

        }

        static int index = 0;
        static void FillMatrix(int row, int col, int[,] matrix)
        {

            if (!InRange(row, col, matrix))
            {
                return;
            }
            if (matrix[row, col] != 0)
                return;
            
            index++;
            if (row+col==matrix.GetLength(0))
            {
                count++;
               
            }
            if (matrix[row, col] == 0)
            {
                matrix[row, col] = index;

                if (row == count/2)
                {
                    FillMatrix(row, col + 1, matrix);
                }
                    
                FillMatrix(row + 1, col, matrix);                              
                FillMatrix(row, col - 1, matrix);
               
                FillMatrix(row - 1, col, matrix);
                count++;

            }

        }

        static bool InRange(int row, int col, int[,] matrix)
        {
            bool rowInRange = row >= 0 && row < matrix.GetLength(0);
            bool colInRange = col >= 0 && col < matrix.GetLongLength(1);            
            return rowInRange && colInRange;
        }
        static int count = 0;
       
    }
}
