namespace GreatestCommonDivisor
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int a = Math.Abs(int.Parse(numbers[0]));
            int b = Math.Abs(int.Parse(numbers[1]));

            int gcd = GCD(a, b);
            Console.WriteLine(gcd);
        }

        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                } 
                else
                {
                    b %= a;
                }
            }

            if (a == 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
