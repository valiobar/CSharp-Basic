using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___Bit_Flipper
{
    class Program
    {
        static void Main()
        {
            ulong n =ulong.Parse( Console.ReadLine());
          //  string binary = Convert.ToString(n,2).PadLeft(64,'0');

         //   int len = binary.Length;
            ulong firsbit = (n>>63)&1;
            ulong newNum = 0;
   //    string binary2 = Convert.ToString(newNum, 2).PadLeft(64, '0');
            Console.WriteLine(firsbit);          
            int count = 0;
            for (int i = 62; i >=0; i--)
            {
                
                
                if (((n >> i) & 1) == ((n >> i+1) & 1))
                {
                    count++;
                }
                if (count==2)
                {
                    
                        if (((n >> i) & 1) ==1)
                        {
                       
                      //  binary2 = Convert.ToString(newNum,2).PadLeft(64, '0');
                       n = (~(ulong)1 << i) & n;
                      //  binary2 = Convert.ToString(newNum,2).PadLeft(64, '0');
                        n = (~(ulong)1 << i+1) & n;
                        n = (~(ulong)1 << i+2) & n;
                        }
                        else
                        {
                        n =((ulong)1 << i) | n;
                    //    binary = Convert.ToString(n, 2).PadLeft(64, '0');
                        n = ((ulong)1 << i+1 )| n;
                        n = ((ulong)1 << i +2)| n;
                        }
                        count = 0;
                    i--;
                  }
                    
                }


            Console.WriteLine(newNum);
        }
    }
}
