using System;

namespace Problem_2.Bonus_Score
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1 :
                case 2:
                case 3:
                    num = num * 10;
                    Console.WriteLine(num);
                    break;
                case 4:
                case 5:
                case 6:
                    num = num * 100;
                    Console.WriteLine(num);
                    break;
                case 7:
                case 8:
                case 9:
                    num = num * 1000;
                    Console.WriteLine(num);
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }




        }
    }
}
