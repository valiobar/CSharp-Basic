using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.__Magic_Dates
{
    class Program
    {
        static void Main()
        {
            
            int sum = 0;
            bool count = false;
            int startYear = int.Parse(Console.ReadLine());
            DateTime startDate = new DateTime(startYear, 01, 01);
            int endYear = int.Parse(Console.ReadLine());
            DateTime endDate = new DateTime(endYear, 12, 31);
            int number = int.Parse(Console.ReadLine());
            for (DateTime i = startDate; i <= endDate; i=i.AddDays(1))
            {
                string date = i.ToString("dd-MM-yyyy");                  
                List<char> clearDate = date.ToList();
                clearDate.Remove('-');
                clearDate.Remove('-');
                string newdate = string.Join(" ", clearDate);
                string[] dateStr =newdate.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                int[] digits = Array.ConvertAll<string, int>(dateStr, int.Parse);
                sum = 0;
                for (int k = 0; k < digits.Length-1; k++)
                {
                    for (int p =k+1; p < digits.Length; p++)
                    {
                        sum =sum+ (digits[p] * digits[k]);
                       
                    }
                }
                if (sum == number)
                {
                    Console.WriteLine(date);
                    count = true;
                }
               
            }
            if (!count)
            {
                Console.WriteLine("No");
            }
           
            
        }
    }
}
