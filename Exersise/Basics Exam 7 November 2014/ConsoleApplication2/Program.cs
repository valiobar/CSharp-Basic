using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<char> number = Convert.ToString(n, 2).PadLeft(32,'0').ToList();
            
            int output = 0;
            while (true)
            {
                int position = 0;
                bool quit = int.TryParse(Console.ReadLine(), out position);
                if (!quit)
                {
                    break;
                }
                string comand= Console.ReadLine();
               
                if (comand=="flip")
                {
                    if (number[31-position] == '1')
                    {
                        number[31-position] = '0';
                    }
                    else number[31-position] = '1';                    
                }
                if (comand == "remove")
                {
                    number.RemoveAt(31 - (position));
                    number.Insert(0, '0');
                }
                if (comand == "insert")
                {
                    number.Insert(31 - (position+1), '1');
                    number.RemoveAt(0);
                }
                if (comand == "skip")
                {
                    continue;
                }
                Console.WriteLine(string.Join("",number));
            }

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i]=='1')
                {
                    output |= 1 << (31 - i);
                }
            }
            Console.WriteLine(output);
        }
    }
}
