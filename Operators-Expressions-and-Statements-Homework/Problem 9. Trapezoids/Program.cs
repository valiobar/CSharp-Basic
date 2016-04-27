using System;


namespace Problem_9.Trapezoids
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter h:");
            double h = double.Parse(Console.ReadLine());
            Console.Write("trapezoid's area :"+(((a+b)/2)* h));
        }
    }
}
