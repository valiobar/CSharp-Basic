using System;


namespace Problem_1.Difference_between_Dates
{
    class Program
    {
        static void Main()
        {
            DateTime start = DateTime.Parse(Console.ReadLine());
            DateTime end = DateTime.Parse(Console.ReadLine());
            double days = (end.Date - start.Date).TotalDays;
            Console.WriteLine(days);

        }
    }
}
