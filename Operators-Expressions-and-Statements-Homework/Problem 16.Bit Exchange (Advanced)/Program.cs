using System;



class Program
{
    static void Main()
    {
        Console.Write("Enter 32-bit unsigned integer:");
        uint n;
        bool  exep = uint.TryParse(Console.ReadLine(),out n);
        Console.Write("Enter first bit position:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter second bit position:");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter step:");
        int k = int.Parse(Console.ReadLine());
        if (!exep) Console.WriteLine("out of range");
        else if (0 > p + k || p + k > 32 || 0 > q + k || q + k > 32)
            Console.WriteLine("out of range"); 
        else if (p + k >= q)
            Console.WriteLine("overlapping");
        else
        {
            for (int i = 0; i < k; i++)
            {
                uint bit1 = (n >> p + i) & 1;
                uint bit2 = (n >> q + i) & 1;
                if (bit1 == 0)
                {
                    n = (uint)(~(1 << q + i) & n);
                }
                else
                    n = (uint)((1 << q + i) | n);
                if (bit2 == 0)
                {
                    n = (uint)(~(1 << p + i) & n);
                }
                else
                    n = (uint)((1 << p + i) | n);

            }
            Console.WriteLine(n);
         }
        }


}
