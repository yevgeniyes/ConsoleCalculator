using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class InputValidation
    {
        //Checking for empty string
        public bool CompleteInputValidation(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(Messages.ERROR_EMPTY_COMMAND);
                return false;
            }
            else return true;
        }

        //Checking number of elements in the array
        public bool CompleteSplitedInputValidation(string[] splitedInput)
        {
            if (splitedInput.Length < 2)
            {
                Console.WriteLine(Messages.ERROR_INVALID_COMMAND);
                return false;
            }
            else return true;
        }
    }
}
