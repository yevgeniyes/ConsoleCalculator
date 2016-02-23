using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class OperationProcessor
    {
        private const string WELCOME_TEXT = "Console Calculator 1.223\nAvailable operations: sum, sub, mult, div\nAvailable variables: int, double\nExample command: sum 3 2.54 18\n";
        private const string ERROR_EMPTY = "Empty command. Available operations: sum, sub, mult, div\n";
        public const string ERROR_WRONG = "Wrong command. Available operations: sum, sub, mult, div. Available variables: int, double\n";
        public const string ERROR_CRITICAL = "Critical error. Please restart application and try again.\n";

        public OperationProcessor()
        {
            Console.WriteLine(WELCOME_TEXT);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter the command:");
                string input = Console.ReadLine();

                //Checking empty string
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(ERROR_EMPTY);
                    continue;
                }

                string[] splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string operation = splitedInput[0];

                //Checking number of elements in the array
                if (splitedInput.Length < 2)
                {
                    Console.WriteLine(ERROR_WRONG);
                    continue;
                }

                var selectedOperarion = OperationSelector.SelectOperation(operation);

                if (selectedOperarion != null)
                {
                    selectedOperarion.CompleteOperation(splitedInput);
                }
            }
        }
    }
}
