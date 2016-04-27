using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_12.Zero_Subset
{
    class Program
    {
        static void Main()
        {
            
            int[] numbers = new int[5];
            bool count = false;
            Console.WriteLine("Enter five number each at separate line");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            if (numbers.Sum() ==0)
            {
                count = true;
                Console.WriteLine(string.Join("+",numbers)+" =0");
            }
            for (int i = 0; i < numbers.Length; i++)
            {

                for (int j = i+1; j < numbers.Length; j++)
                {
                    
                        
                        if (numbers[i]+numbers[j]==0)
                        {
                        count = true;
                        Console.WriteLine("{0} {1}=0",numbers[i],numbers[j]);

                        }
                    
                    for (int k = j+1; k < numbers.Length; k++)
                    {
                        
                          
                            if (numbers[i] + numbers[j]+numbers[k] == 0)
                            {
                            count = true;
                            Console.WriteLine("{0}+{1}+{2}=0", numbers[i], numbers[j],numbers[k]);
                            }


                        for (int p = k + 1; p < numbers.Length ; p++)
                        {

                           
                            if (numbers[i] + numbers[j] + numbers[k]+numbers[p] == 0)
                            {
                            count = true;
                            Console.WriteLine("{0}+{1}+{2}+{3}=0", numbers[i], numbers[j], numbers[k], numbers[p]);
                            }                       
                        }
                    }
                }               
            }
            if (!count)
            {
                Console.WriteLine("no zero subset");
            }
                
            
        }
    }
}
