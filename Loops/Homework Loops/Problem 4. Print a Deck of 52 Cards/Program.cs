using System;


namespace Problem_4.Print_a_Deck_of_52_Cards
{
    class Program
    {
        static void Main()
        {            
            char[] symbols = { '\u2663', '\u2666', '\u2665',  '\u2660' };
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                {
                    Console.Write("{0}{1}",cards[i],symbols[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
