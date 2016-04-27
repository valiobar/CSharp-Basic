using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Matrix_of_Palindromes
{
    class Program
    {
        static string str(int row, int col)
        {

            char[] newch = { (char)((int)'a' + row), (char)((int)'a' + row + col), (char)((int)'a' + row) };
            string str = string.Join("",newch);
            return str;
        }

        static void Main()
        {
            Console.Write("Enter rows:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter columns:");
            int col = int.Parse(Console.ReadLine());
            string[,] matrix = new string[row, col];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = str(i, j);
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ",matrix[i,j]  );
                }
                Console.WriteLine();
            }
        }
    }
}
