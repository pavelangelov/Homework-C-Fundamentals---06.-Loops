namespace PrintADeck
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] cardFace = new string[13]
            {
                "2","3","4","5","6","7","8","9","10","J","Q","K","A"
            };
            string[] cardSuits = new string[4]
            {
                " of spades", " of clubs", " of hearts", " of diamonds"
            };
            for (int i = 0; i < cardFace.Length; i++)
            {
                if (input == cardFace[i])
                {
                    for (int j = 0; j < cardSuits.Length; j++)
                    {
                        if (j < cardSuits.Length - 1)
                        {
                            Console.Write(" {0}{1},", cardFace[i], cardSuits[j]);
                        }
                        else
                        {
                            Console.Write(" {0}{1}", cardFace[i], cardSuits[j]);
                        }
                    }
                    break;
                }
                for (int k = 0; k < cardSuits.Length; k++)
                {
                    if (k < cardSuits.Length - 1)
                    {
                        Console.Write(" {0}{1},", cardFace[i], cardSuits[k]);
                    }
                    else
                    {
                        Console.Write(" {0}{1}", cardFace[i], cardSuits[k]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
