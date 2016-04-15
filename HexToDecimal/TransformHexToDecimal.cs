namespace HexToDecimal
{
    using System;

    class TransformHexToDecimal
    {
        static void Main()
        {
            string hexForm = Console.ReadLine();
            ulong decimalForm = 0;
            for (int i = hexForm.Length - 1; i >= 0; i--)
            {
                char hexSymbol = hexForm[i];
                if (char.IsDigit(hexSymbol))
                {
                    decimalForm += (ulong)((hexSymbol - '0') * Math.Pow(16, hexForm.Length - i - 1));
                }
                else
                {
                    switch (hexSymbol)
                    {
                        case 'A':
                            decimalForm += (ulong)(10 * Math.Pow(16, hexForm.Length - i - 1));
                            break;
                        case 'B':
                            decimalForm += (ulong)(11 * Math.Pow(16, hexForm.Length - i - 1));
                            break;
                        case 'C':
                            decimalForm += (ulong)(12 * Math.Pow(16, hexForm.Length - i - 1));
                            break;
                        case 'D':
                            decimalForm += (ulong)(13 * Math.Pow(16, hexForm.Length - i - 1));
                            break;
                        case 'E':
                            decimalForm += (ulong)(14 * Math.Pow(16, hexForm.Length - i - 1));
                            break;
                        case 'F':
                            decimalForm += (ulong)(15 * Math.Pow(16, hexForm.Length - i - 1));
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine(decimalForm);
        }
    }
}
