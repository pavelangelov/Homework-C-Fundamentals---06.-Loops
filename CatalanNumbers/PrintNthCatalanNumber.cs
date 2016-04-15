namespace CatalanNumbers
{
    using System;
    using System.Numerics;

    class PrintNthCatalanNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = Factorial(n * 2) / (Factorial(n + 1) * Factorial(n));

            Console.WriteLine(result);
        }

        private static BigInteger Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
