using System;



    class AgeAfterYears
    {
        static void Main()
    {
        Console.WriteLine("Type your birthday dd.mm.yyyy");
       
        string inputDate =Console.ReadLine();
        string year = inputDate.Substring(6, 4);
        object nowDate =DateTime.Now ;
        int ryear = int.Parse(year);
        int now = (2015 - ryear);
        int after = now + 10;
         
        Console.WriteLine("Now:{0}\nAfter 10 years;{1}",now,after);
         
       
    }



    }

