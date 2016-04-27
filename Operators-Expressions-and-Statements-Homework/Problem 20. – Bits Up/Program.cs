using System;

    class Program
    {
        static void Main()
        {
        int muli = 1;
        int numberPrint = 0;
        int index = 0;
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        char[] numberArr = null;
        string numberStr = null;
        string numberIdex = null;
        short number = 0;
        for (int i = 0; i < n; i++)
        {
            number = short.Parse(Console.ReadLine());
            numberStr = Convert.ToString(number, 2).PadLeft(8, '0');
            numberIdex = numberIdex + numberStr;
            numberArr = numberIdex.ToCharArray();
        }
        for (int i = 1; i < numberArr.Length; i=i+step)
        {
            numberArr[i] = '1';
        }
       

        for (int i = 0; i < numberArr.Length/8; i++)
        {
            
            for (int j = 7; j >= 0; j--)
            {
                  if (numberArr[index]=='1')
               {
                    int numbreInt = 1 << j;
                     numberPrint = numberPrint | numbreInt;
                    
               }
                index++;
            }
            index = muli* 8;
            muli++;
            Console.WriteLine(numberPrint);
            numberPrint = 0;
        }
    }
    }

