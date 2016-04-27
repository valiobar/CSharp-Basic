using System;



    class Program
    {
        static void Main()

    {
      
        string yearType = Console.ReadLine();
        
        string p = Console.ReadLine();
        int numberHolidays = int.Parse(p);
        
        string h = Console.ReadLine();
        int homeTownWeekends = int.Parse(h);
        if (yearType == "t") 
        {
            Console.WriteLine(Math.Floor(((52-homeTownWeekends)*2/3 )+0.5*numberHolidays+3+homeTownWeekends));
        }
        else 
        {
            Console.WriteLine((Math.Floor(((52 - homeTownWeekends) * 2 / 3) + 0.5 *numberHolidays+homeTownWeekends )));
        }

         
        

    }
    }
