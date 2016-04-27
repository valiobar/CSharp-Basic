using System;
using System.Text;

    class Program
    {
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char ch = '©';
        char inter = ' ';
            for (int row = 1; row <= 4; row++)
        {
            string intr = new String(inter, (5 - row));
            Console.Write(intr);
                for (int col = 1; col <= row; col++)
                {
                             
                     Console.Write(ch+" ");
                }
            
           Console.WriteLine();
        }
     }
    }

