using System;


namespace Problem_11.Number_as_Words
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            string hundreds = "";
            string tens= "";
            string ones = "";
            string[] onesArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", };
            string[] tensArr = { "zero", "ten", "twenty", "thirty", "forty", "fifity", "sixty", "seventy", "eighty", "ninety", };
            string[] tensAfterTen = { "zero", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineten" };
            if (number / 100 > 0)
            {
                hundreds = onesArr[number / 100] + " hundreds";
                if ((number % 100) / 10 > 0)
                {
                    if ((number % 100) % 10 == 0)
                    {
                        tens = tensArr[((number % 100) / 10)];
                        Console.WriteLine("{0}and{1}", hundreds, tens);

                    }
                    else if ((number % 100) > 19)
                    {
                        tens = tensArr[((number % 100) / 10)];
                        ones = onesArr[((number % 100) % 10)];
                        Console.WriteLine("{0} and {1} {2}", hundreds, tens, ones);
                    }
                    else
                    {
                        tens = tensAfterTen[((number % 100) % 10)];
                        Console.WriteLine("{0} and {1}", hundreds, tens);
                    }

                }
                else
                {
                    ones = onesArr[(number % 100) % 10];
                    Console.WriteLine("{0} and {1}", hundreds, ones);
                }

            }
            else if (number / 10 > 0 && number % 10 == 0)
            {
                tens = tensArr[number / 10];
                Console.WriteLine(tens);
            }
            else if (number / 10 > 0)
            {
                tens = tensArr[number / 10];
                ones = onesArr[number % 10];
                Console.WriteLine("{0} {1}", tens, ones);
            }
            else
            {
             ones=onesArr[number%10];
                    
            }

         }
    }
}
