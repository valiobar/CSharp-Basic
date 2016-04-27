using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_23.__Five_Special_Letters
{
    class Program
    {
        static int count = 0;
        static void Main()
        {
           
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            char[] letters = new char[5];
            
            if (Findcombination(start, end, 0, letters)==0)
            {
                Console.WriteLine("No");
            }
        }
        static int Findcombination(int start, int end,int index,char[]letters)
        {           
           
            if (index > 4)
            {
               if (Sum(letters) >= start && Sum(letters) <= end)
                {
                    Console.Write(string.Join("", letters) + " ");
                    count ++;                  
                }                
            }
            else
            {
                for (char i = 'a'; i <= 'e'; i++)
                {
                    letters[index] = i;
                    Findcombination(start, end, index + 1, letters);
                }
            }
            
            return count;
        }

        static int weight (char letter)
        {
            int weight = 0;
           switch(letter)
            {
                case 'a': weight = 5;break;
                case 'b': weight = -12; break;
                case 'c': weight = 47; break;
                case '3': weight = 7; break;
                case 'e': weight = -32; break;

            }
            return weight;
        }
        static int Sum (char[] letters )
        {
           int sum = 0;
            List<char> newLetters = letters.Distinct().ToList();
           
            for (int i = 0,j=1; i < newLetters.Count;j++, i++)
            {
                sum = sum + j * weight(newLetters[i]);
            }
            return sum;
        }
    }
}
