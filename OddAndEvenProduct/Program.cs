namespace OddAndEvenProduct
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string inputNumbers = Console.ReadLine();
            string[] numbersArr = inputNumbers.Split(' ');
            ulong oddsProduct = 1;
            ulong evensProduct = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    oddsProduct *= ulong.Parse(numbersArr[i]);
                }
                else
                {
                    evensProduct *= ulong.Parse(numbersArr[i]);
                }
            }

            if (oddsProduct == evensProduct)
            {
                Console.WriteLine("yes {0}", oddsProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddsProduct, evensProduct);
            }
        }
    }
}
