using System;
using System.Collections.Generic;

namespace Conversion_of_Decimal
{
    internal class UserChoice
    { 
        /// <summary>
        /// This allows user to enter numbers
        /// between 0 and 65535
        /// </summary>
        public int StartConversion()
        {
            int uInput = 0;
            Console.Write("Enter numbers between 0 and 65535: ");
            uInput = int.Parse(Console.ReadLine());
            ValidateUserInput(uInput);
            Console.ReadKey();

            return uInput;
        }

        /// <summary>
        /// This checks user input if 
        /// between 0 and 65535
        /// </summary>
        /// <param name="uInput"></param>
        /// <returns> validated user Input </returns>
        private int ValidateUserInput(int uInput)
        {
            while (uInput < 0 || uInput > 65535) 
            {
                Console.Clear();
                Console.WriteLine("Numbers must be between 0 and 65535 only!");
                Console.Write("Please enter again: ");
                uInput = int.Parse(Console.ReadLine()); 
            } 

            return uInput;
        }

        /// <summary>
        /// Checks if user wants to continue the program
        /// </summary>
        public bool ConvertAgain()
        {
            char uChoice = ' ';
            
            Console.Write("\nConvert again? [Y/N]: ");
            uChoice = char.Parse(Console.ReadLine().ToUpper());
            ValidateUserChoice(uChoice);
           
            if (uChoice == 'N')
            {
                return false;
            }
            return true;
        }

        private char ValidateUserChoice(char uChoice)
        {
            while(uChoice != 'Y' || uChoice != 'N') 
            {
                Console.WriteLine("Please input Y or N only!");
                Console.Write("Convert again? [Y/N]: ");
                uChoice = char.Parse(Console.ReadLine().ToUpper());
            }

            return uChoice;
        }
    }
}
