using System;
using System.Collections.Generic;

namespace Conversion_of_Decimal
{
    internal class Conversions
    {
        /// <summary>
        /// Converts decimal given by user to binary
        /// </summary>
        /// <param name="DtB"></param>
        /// <returns>binary for of the decimal</returns>
        public string DecimalToBinary(int DtB)
        {
            int[] BinArray = new int[16];

            for (int i = 0; DtB > 0; i++)
            {
                BinArray[i] = DtB % 2;
                DtB /= 2;
            }

            Array.Reverse(BinArray);
            string binary = "";

            for (int i = 0; i < BinArray.Length; i++)
            {
                binary += BinArray[i];

                if ((i + 1) % 4 == 0)
                {
                    binary += " ";
                }
            }

            return binary;
        }

        /// <summary>
        /// Converts decimal given by user to octal
        /// </summary>
        /// <param name="DtO"></param>
        /// <returns>octal form of the decimal</returns>
        public string DecimalToOctal(int DtO)
        {
            {
                int[] OctArray = new int[6];

                for (int i = 0; DtO > 0; i++)
                {
                    OctArray[i] = DtO % 8;
                    DtO /= 8;
                }

                Array.Reverse(OctArray);
                string octal = "";

                for (int i = 0; i < OctArray.Length; i++)
                {
                    octal += OctArray[i];

                    if ((i + 1) % 3 == 0)
                    {
                        octal += " ";
                    }
                }

                return octal;
            }
        }

        /// <summary>
        /// Converts decimal given by user to hexadecimal
        /// </summary>
        /// <param name="DtH"></param>
        /// <returns>hexadecimal form of the decimal</returns>
        public string DecimalToHexadecimal(int DtH)
        {
            char[] HexArray = new char[4];
            char[] HexDig = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int remainder;
            int i = 0;
            while (DtH > 0 && i < 4)
            {
                remainder = DtH % 16;
                DtH /= 16;

                if (remainder > 9)
                {
                    HexArray[i] = HexDig[remainder];
                }
                else
                {
                    HexArray[i] = (char)('0' + remainder);
                }
                i++;
            }
            while (i < 4)
            {
                HexArray[i] = '0';
                i++;
            }

            Array.Reverse(HexArray);

            string hex = "";
            foreach (char c in HexArray)
            {
                hex += c;
            }

            return hex;
        }
    }
}
