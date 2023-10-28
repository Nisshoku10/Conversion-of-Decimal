using System;
using System.Collections.Generic;

namespace Conversion_of_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserChoice uc = new UserChoice();
            Conversions conv = new Conversions();

            do
            {
                Console.Clear();
                int uNum = uc.StartConversion();

                Console.Clear();

                Console.WriteLine("The Conversions: ");
                Console.WriteLine("The given decimal is {0}", uNum);
                Console.WriteLine("The binary form is {0}", conv.DecimalToBinary(uNum));
                Console.WriteLine("The octal form is {0}", conv.DecimalToOctal(uNum));
                Console.WriteLine("The hexadecimal form is {0}", conv.DecimalToHexadecimal(uNum));
                Console.ReadKey();
            } while (uc.ConvertAgain());
        }
    }
}
