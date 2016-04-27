using System;

    class Program
    {
        static void Main()
        {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong newNum = 0;
        int bitCount = 0;
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            ulong num = ulong.Parse(Console.ReadLine());

            for (int j = 0; j < 64; j++)
            {
                ulong nbit = (n >> j) & 1;
                ulong numbit = (num >> j) & 1;
                if (nbit > numbit)
                    newNum =((ulong)1 << j)|newNum;
                

            }
            n = newNum;
            newNum = 0;
        }
      // Console.WriteLine(n);
        for (int i = 0; i < 64; i++)
        {
            ulong check = (n >> i) & 1;
            if (check == 1)
                bitCount += 1;
        }
        Console.WriteLine(bitCount);
    }
    }

