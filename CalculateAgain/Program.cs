namespace Calculate_
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger sum = Factorial(n) / Factorial(k);

            Console.WriteLine(sum);
        }

        private static BigInteger Factorial(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * Factorial(i - 1);
        }


    }
}