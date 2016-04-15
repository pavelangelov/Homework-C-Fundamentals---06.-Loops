namespace DecimalToHex
{
    using System;

    class Program
    {
        static void Main()
        {
            ulong decimalForm = ulong.Parse(Console.ReadLine());
            string hexForm = "";
            while (decimalForm >= 1)
            {
                ulong remainder = decimalForm % 16;
                if (remainder < 10)
                {
                    string remaindeStr = remainder.ToString();
                    hexForm = remaindeStr + hexForm;
                }
                else
                {
                    switch (remainder)
                    {
                        case 10:
                            hexForm = "A" + hexForm;
                            break;
                        case 11:
                            hexForm = "B" + hexForm;
                            break;
                        case 12:
                            hexForm = "C" + hexForm;
                            break;
                        case 13:
                            hexForm = "D" + hexForm;
                            break;
                        case 14:
                            hexForm = "E" + hexForm;
                            break;
                        case 15:
                            hexForm = "F" + hexForm;
                            break;
                        default:
                            break;
                    }
                }
                decimalForm /= 16;
            }

            Console.WriteLine(hexForm);
        }
    }
}
