using System;


namespace Problem_13.__Triangle
{
    class Program
    {
        static void Main()
        {
           
            int Ax = int.Parse(Console.ReadLine());
            int Ay = int.Parse(Console.ReadLine());
            int Bx = int.Parse(Console.ReadLine());
            int By = int.Parse(Console.ReadLine());
            int Cx = int.Parse(Console.ReadLine());
            int Cy = int.Parse(Console.ReadLine());
            double AB = Math.Sqrt(Math.Pow((Bx - Ax),2) + Math.Pow((By - Ay), 2));
            double BC = Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By), 2));
            double AC = Math.Sqrt(Math.Pow((Cx - Ax), 2) + Math.Pow((Cy - Ay), 2));
            if (AB+BC>AC&&AB+AC>BC&&AC+BC>AB)
            {
                double halfPer = (AB + BC + AC) / 2;
                double area = Math.Sqrt (halfPer*(halfPer- AB)*(halfPer - BC)*(halfPer - AC));
                Console.WriteLine("Yes");
                Console.WriteLine("{0:f2}",area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}",AB);
            }
        }
    }
}
