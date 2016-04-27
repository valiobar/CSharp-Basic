using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address:");
        string companyAdress = Console.ReadLine();
        Console.Write("Phone number:");
        string companyNumber = Console.ReadLine();
        Console.Write("Fax number:");
        string faxNumer = Console.ReadLine();
        if (faxNumer==null)
        { faxNumer = "(no fax)"; }
        Console.Write("Web site:");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name:");
        string managerFirst = Console.ReadLine();
        Console.Write("Manager last name:");
        string managerLast = Console.ReadLine();
        Console.Write("Manager age:");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone:");
        string managerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Adress :"+companyAdress);
        Console.WriteLine("Tel."+companyNumber);
        Console.WriteLine("Fax."+faxNumer);
        Console.WriteLine(@"Web site: "+webSite);
        Console.WriteLine("Manager:{0} {1} {2} {3}",managerFirst,managerLast,managerAge,managerPhone);


    }
    }
