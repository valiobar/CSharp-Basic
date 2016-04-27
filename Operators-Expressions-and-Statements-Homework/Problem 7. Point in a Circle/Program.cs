using System;


namespace Problem_7.Point_in_a_Circle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter coordinate x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y:");
            double y = double.Parse(Console.ReadLine());
            bool insite = Math.Sqrt(x * x + y * y) <= 2;
            Console.WriteLine(insite);
        }
    }
}
