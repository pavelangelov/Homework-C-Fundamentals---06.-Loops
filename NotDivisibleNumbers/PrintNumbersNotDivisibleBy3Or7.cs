namespace NotDivisibleNumbers
{
    using System;

    class PrintNumbersNotDivisibleBy3Or7
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNum; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    if (i == inputNum)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
