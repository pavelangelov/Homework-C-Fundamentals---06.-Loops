namespace MMSAOfNNumbers
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0.0;
            double average;
            for (int i = 0; i < n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());
                if (min > currentNum)
                {
                    min = currentNum;
                }
                if (max < currentNum)
                {
                    max = currentNum;
                }

                sum += currentNum;
            }

            average = sum / n;

            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", average);
        }
    }
}
