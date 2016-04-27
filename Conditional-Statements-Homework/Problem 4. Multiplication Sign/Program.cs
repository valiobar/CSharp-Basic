using System;


namespace Problem_4.Multiplication_Sign
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter firs number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number:");
            int c = int.Parse(Console.ReadLine());
            if ((a * b * c) > 0)
            {
                Console.WriteLine("+");
            }
            else if ((a * b * c) < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
