using System;

    class Program
    {
      static void Main()
     {
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c:");
        double c = double.Parse(Console.ReadLine());
        double D = b * b - 4 * a * c;
        if (D>0)
        {
            double root1 = (-b + Math.Sqrt(D)) /( 2 * a);
            double root2 = (-b -Math.Sqrt(D)) / (2 * a);
            Console.WriteLine( "roots:x1={0} x2={1}",root1,root2);
        }
        else  if (D == 0)
        {
            double root = -(b /( 2 * a));
            Console.WriteLine( "root:"+root);
        }
        else
            Console.WriteLine("no real roots");
    }
    }

