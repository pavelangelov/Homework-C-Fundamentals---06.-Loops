namespace Calculate_
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            int factorial = 1;
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += (factorial / Math.Pow(x, i));
            }

            Console.WriteLine("{0:F5}", sum);


        }
        
    }
}
