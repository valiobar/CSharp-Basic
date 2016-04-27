using System;


    class Program
    {
        static void Main()
        {
        
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        bool eps = Math.Abs(a - b) < 0.000001;
        Console.WriteLine(eps);
       
    }
   
}





    