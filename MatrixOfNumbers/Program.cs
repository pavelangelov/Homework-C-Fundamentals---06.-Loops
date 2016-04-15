namespace MatrixOfNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string matrixRow = "";
            int count = 0;
            for (int i = 1; i <= n * 2; i++)
            {
                
                if (count < n)
                {
                    if (count == n - 1)
                    {
                        matrixRow += i;
                        count++;
                        continue;
                    }
                    matrixRow += i + " ";
                    count++;
                    continue;
                }
                Console.WriteLine(matrixRow);
                matrixRow = "";
                i = i - count;
                count = 0;

            }
        }
    }
}
