using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Entr type of year - leap/normal:");
        string typeOfYear = Console.ReadLine();
        Console.Write("Enter number of hollydays:");
        double hollydays = double.Parse(Console.ReadLine());
        Console.Write("Enter numbres of weekends vlado spends in his home town:");
        double homeTown = double.Parse(Console.ReadLine());
        double numberOfGames = 0.75 *( 48-homeTown) + (hollydays * 2) / 3+homeTown;
        if (typeOfYear=="normal")
        { Console.WriteLine(Math.Floor(numberOfGames)); }
        else
            Console.WriteLine(Math.Floor(numberOfGames+(numberOfGames*15)/100));
        }
    }

