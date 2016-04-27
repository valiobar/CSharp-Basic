using System;


namespace PrintaSequence
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i <= 1001; i++)
            {
                if ((i % 2) == 0)
                    Console.Write(i + ",");
                else
                    Console.Write(i * -1 + ",");
            }
        }
    }
}
