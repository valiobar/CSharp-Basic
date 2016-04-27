using System;


namespace Problem_11.__Student_Cables
{
    class Program
    {
        static void Main()
        {
            int cableCurentLenght = 0;
            int cableLenght=0;
            int number = int.Parse(Console.ReadLine());
            string[,] cables = new string[number, 2];
            for (int row = 0; row < cables.GetLength(0); row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    cables[row, col] = Console.ReadLine();
                }
            }
            for (int row = 0; row < cables.GetLength(0); row++)
            {
                if (cables[row, 1] == "meters")
                {
                    cableCurentLenght = int.Parse(cables[row, 0]) * 100;
                }
                else cableCurentLenght = int.Parse(cables[row, 0]);
                if (cableCurentLenght >= 20)
                {
                    cableLenght += cableCurentLenght;
                }
                else continue;
                if (row!=cables.GetLength(0)-1)
                {
                    cableLenght = cableLenght - 3;
                }
                cableCurentLenght = 0;
            }
            Console.WriteLine(cableLenght/504);
            Console.WriteLine(cableLenght%504);
        }
    }
}
