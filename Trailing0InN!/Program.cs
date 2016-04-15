namespace Trailing0InN_
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int divider = 5;
            int result = 0;
            while (divider <= n)
            {
                result += n / divider;
                divider *= 5;
            }

            Console.WriteLine(result);
        }
    }
}
