using System;

class Employee_Data
{
    static void Main()
    {
        Console.Write("Enter employee name:");
        string name = Console.ReadLine();
        Console.Write("Enter employee middlename:");
        string middleName = Console.ReadLine();
        Console.Write("Enter employee surname:");
        string surname = Console.ReadLine();
        Console.Write("Enter balance :");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Bank Name:");
        string bankName = Console.ReadLine();
        Console.Write("Enter IBAN:");
        string IBAN = Console.ReadLine();
        Console.Write("Enter CCnumber: ");
        long ccNumber1 = long.Parse(Console.ReadLine());
        Console.Write("Enter CCnumber: ");
        long ccNumber2 = long.Parse(Console.ReadLine());
        Console.Write("Enter CCnumber: ");
        long ccNumber3= long.Parse(Console.ReadLine());
        
        Console.WriteLine("First name:{0}\nMiddle name: {1}\nSurname: {2}\nBalance: {3}\nBank:{4}\nIBAN: {5}\nCC:{6}\nCC:{7}\nCC:{8}", name, middleName, surname, balance, bankName, IBAN, ccNumber1, ccNumber2, ccNumber3);



    }
}

