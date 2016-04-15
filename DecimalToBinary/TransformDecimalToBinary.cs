namespace DecimalToBinary
{
    using System;

    class TransformDecimalToBinary
    {
        static void Main()
        {
            ulong decimalForm = ulong.Parse(Console.ReadLine());
            string binaryForm = "";
            while (decimalForm >= 1)
            {
                string bitValue = (decimalForm % 2).ToString();
                binaryForm = bitValue + binaryForm;
                decimalForm /= 2;
            }

            Console.WriteLine(binaryForm);
        }
    }
}
