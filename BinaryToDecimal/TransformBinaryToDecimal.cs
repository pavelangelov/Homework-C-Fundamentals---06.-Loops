namespace BinaryToDecimal
{
    using System;

    class TransformBinaryToDecimal
    {
        static void Main()
        {
            string binaryForm = Console.ReadLine();
            ulong decimalForm = 0;
            for (int i = binaryForm.Length - 1; i >= 0; i--)
            {
                int bitValue = binaryForm[i] - '0';
                if (bitValue == 1)
                {
                    decimalForm += (ulong)Math.Pow(2, binaryForm.Length - i - 1);
                }
            }

            Console.WriteLine(decimalForm);
        }
    }
}
