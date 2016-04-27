using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_20.__Exam_Schedule
{
    class Program
    {
        static void Main()
        {
            int starHour = int.Parse(Console.ReadLine());
            int starMinutes = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            int durationHour = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());
            string examPartOfDay = partOfDay;
            int endHour = starHour + durationHour;
            int endMinutes = starMinutes + durationMinutes;
            if (endMinutes >= 60)
            {
                endMinutes = endMinutes - 60;
                endHour++;
            }
            if (endHour>12)
            {                
                endHour = endHour - 12;
                if (examPartOfDay=="AM")
                {
                    examPartOfDay = "PM";
                }
                else
                {
                    examPartOfDay = "AM";
                }                
            }
            if (endHour == 12)
            {
                if (examPartOfDay == "AM")
                {
                    examPartOfDay = "PM";
                }
                else
                {
                    examPartOfDay = "AM";
                }
            }
            Console.WriteLine("{0:00}:{1:00}:{2}",endHour,endMinutes,examPartOfDay);
            
        }
    }
}
