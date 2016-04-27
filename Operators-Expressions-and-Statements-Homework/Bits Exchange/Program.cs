using System;

    class Program
    {
        static void Main()
        {
        Console.Write("Enetr 32-bit unsigned integer :");
        uint n = uint.Parse(Console.ReadLine());
        uint bit26 = (n >> 26)&1;
        uint bit25 = (n >> 25)&1;
        uint bit24 = (n >> 24)&1;
        uint bit3 = (n >> 3) & 1;
        uint bit4 = (n >> 4) & 1;
        uint bit5 = (n >> 5) & 1;
        if (bit24 == 0)
        {
            n = (uint)(~(1 << 3) & n);
        }
        else n = (1 << 3) | n;
        if (bit25 == 0)
        {
            n = (uint)(~(1 << 4) & n);
        }
        else n = (1 << 4) | n;
        if (bit26 == 0)
        {
            n = (uint)(~(1 << 5) & n);
        }
        else n = (1 << 5) | n;
        if (bit3 == 0)
        {
            n = (uint)(~(1 << 24) & n);
        }
        else n = (1 << 24) | n;
        if (bit4 == 0)
        {
            n = (uint)(~(1 << 25) & n);
        }
        else n = (1 << 25) | n;
        if (bit5 == 0)
        {
            n = (uint)(~(1 << 26) & n);
        }
        else n = (1 << 26) | n;
        Console.WriteLine(n);
    }
    }

