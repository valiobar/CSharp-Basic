using System;


namespace Problem_3.Check_for_a_Play_Card
{
    class Program
    {
        static void Main()
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K ", "A" };
            string yourCard = Console.ReadLine();
            bool check = false;

            for (int i = 0; i < cards.Length; i++)

            {
                if (yourCard == cards[i])
                {
                     check = true;
                }
           
            }
            if (check)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
