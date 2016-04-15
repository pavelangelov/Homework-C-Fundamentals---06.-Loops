namespace Calculate3_
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger result = Factorial(n) / (Factorial(k) * Factorial(n - k));

            Console.WriteLine(result);
        }

        private static BigInteger Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return Factorial(n - 1);
        }
    }
}
