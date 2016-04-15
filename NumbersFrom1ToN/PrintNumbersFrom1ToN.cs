namespace NumbersFrom1ToN
{
    using System;

    class PrintNumbersFrom1ToN
    {
        static void Main()
        {
            uint inputNum = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNum; i++)
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
