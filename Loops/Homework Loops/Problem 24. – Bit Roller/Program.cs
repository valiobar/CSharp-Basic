using System;


namespace Problem_24.__Bit_Roller
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int forzenBit = int.Parse(Console.ReadLine());
            int roll = int.Parse(Console.ReadLine());         
            int pillarBit = (number >> forzenBit) & 1;
            number = number & ~(1 << forzenBit);        

            for (int i = 0, j = 1; i < roll; j++, i++)
            {

                int freez = number & 1;
                if (freez == 1)
                {
                    number = number >> 1 | 1 << 18;
                }
                else
                {
                    number = number >> 1;
                }
                if (((number>>forzenBit)&1)==1)
                {
                    number = number | (1 << forzenBit - 1);
                    number = number & ~(1 << forzenBit);
                }

                
            }
            
            number = number | (pillarBit << forzenBit);
            
            Console.WriteLine(number);
        }
        }
}
