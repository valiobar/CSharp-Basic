using System;


namespace Problem_10.Odd_and_Even_Product
{
    class Program
    {
        static void Main()
        {
            int oddProduct = 1;
            int evenProduct = 1;
            Console.WriteLine("Enter intiger numbers split by space:");
            string[] numbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    oddProduct *= int.Parse(numbers[i]);
                }
                else
                {
                    evenProduct *= int.Parse(numbers[i]);
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("product={0}", oddProduct);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("odd product={0}", oddProduct);
                Console.WriteLine("even product={0}", evenProduct);
            }
        }
    }
}
