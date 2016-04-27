using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Car_Numbers
{
    class Program
    {
        static int[] digits = new int[4];
        static int count = 0;
        static int DigitCominations(int sum,int index)
        {
            
            
            
            if (index > 3)
            {
                if (digits.Sum()==sum)
                {
                    count++;
                }
                
            }
            else
            {
                for (int i = 1; i < 10; i++)
                {
                    if (index == 2 && digits[0] != digits[1])
                    {
                        if (i == digits[1] || i == digits[0])
                        {
                            digits[index] = i;
                        }
                    }
                    if (index == 3 && digits[0] != digits[1])
                    {
                        if (i != digits[2] && (i == digits[0] || i == digits[1]))
                        {
                            digits[index] = i;
                        }
                    }
                    else if (digits[2] != digits[1])
                    {
                        digits[index] = digits[2];
                    }
                    digits[index ]=i;
                    DigitCominations(sum, index + 1);
                }
            }
            return count;
        }
       
            static void Main()
        {
            int result = 0;
            int n= int.Parse(Console.ReadLine());
            int magicSum = n - 40;
            int sum = 0;
            int[] letters = { 10, 20, 30, 50, 80, 110, 130, 160, 200 };
            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    sum = magicSum - (letters[i] + letters[j]);
                    if (DigitCominations(sum, 0)>0)
                    {
                        result = DigitCominations(sum, 0) + 1;
                    }
                }
               
            }
            Console.WriteLine(result);
        }

    }
}
