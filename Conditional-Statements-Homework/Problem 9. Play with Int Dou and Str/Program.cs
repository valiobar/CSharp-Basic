using System;


namespace Problem_9.Play_with_Int_Dou_and_Str
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"1 --> int
2 --> double
3 --> string
");
            Console.Write("Please choose a type:");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    {
                        Console.WriteLine("Please enter an integer:");
                        int intNum = int.Parse(Console.ReadLine());
                        Console.WriteLine(intNum + 1);break;
                    }
                case 2:
                    {
                        Console.WriteLine("Please enter a double:");
                        double doubleNum = double.Parse(Console.ReadLine());
                        Console.WriteLine(doubleNum + 1); break;
                    }
                case 3:
                    {
                        Console.WriteLine("Please enter a string:");
                        string strNum = Console.ReadLine();
                        Console.WriteLine(strNum +"*"); break;
                    }
                default:
                    Console.WriteLine("Enter valid type");
                    break;
            }
        }
    }
}
