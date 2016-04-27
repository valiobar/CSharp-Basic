using System;

    class Employee_Data
    {
        static void Main()
        {
        Console.Write("Enter employee name:");
        string name = Console.ReadLine();
        Console.Write("Enter employee surname:");
        string surname = Console.ReadLine();
        Console.Write("Enter employee age:");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter employee gender'\'(m/f\0:'\')");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Enter personal ID number: ");
        long personalID = long.Parse(Console.ReadLine());
        Console.Write("Enter Unique Employee number:  ");
        int uniqueeNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("First name:{0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID:{4}\nUnique Employee number: {5}",name,surname,age,gender,personalID,uniqueeNumber);



    }
    }

