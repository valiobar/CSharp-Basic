using System;

namespace Problem_10.Beer_Time
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter time in format (hh:mm tt):");
            DateTime time = new DateTime();
            bool check = DateTime.TryParse(Console.ReadLine(), out time);
            if (!check)
            {
                Console.WriteLine("Enter data in valiud format");
                Main();
            }
            else
         
            {
                DateTime start = new DateTime(time.Year, time.Month, time.Day, 3, 0, 0);
                DateTime end = new DateTime(time.Year, time.Month, time.Day, 13, 0, 0);
                if (time > start && time < end)
                {
                    Console.WriteLine("non-beer time");
                }
                else
                {
                    Console.WriteLine("beer time");
                }
            }
            
            
        }
    }
}
