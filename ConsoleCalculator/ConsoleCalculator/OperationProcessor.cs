using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class OperationProcessor
    {
        public const string WELCOME_TEXT = "Console Calculator 1.225\n\nAvailable operations for calculator: sum, sub, mult, div. Available variables: int, double\nExample command: sum 3 2.54 18\n\nAvailable operations for files: create, delete, copy, move\nExample command: create C:\\New\\SomeFile.txt\n";
        public const string ERROR_EMPTY = "Empty command. Available operations: sum, sub, mult, div\n";
        public const string ERROR_CALC_WRONG = "Wrong command. Available operations: sum, sub, mult, div.\nAvailable variables: int, double\n";
        public const string ERROR_FILE_WRONG = "Wrong command. Available operations: create, delete, copy, move.\nPath example: C:\\New_folder\\SomeFile.txt\n";
        public const string ERROR_WRONG_OPERATION = "Wrong operation. Available operations for calculator: sum, sub, mult, div\nAvailable operations for files: create, delete, copy, move\n";
        public const string ERROR_CRITICAL = "Critical error. Please restart application and try again.\n";

        public OperationProcessor()
        {
            Console.WriteLine(WELCOME_TEXT);
        }
        //Main logic: read input, validate input, split input, validate splited input, select operation, complete operation
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter the command:");
                string input = Console.ReadLine();

                var validator = new InputValidation();
                if (!validator.CompleteInputValidation(input)) continue;

                string[] splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!validator.CompleteSplitedInputValidation(splitedInput)) continue;

                string operation = splitedInput[0];

                var fabric = new OperationFabric();
                var selectedOperarion = fabric.SelectOperation(operation);

                if (selectedOperarion != null)
                {
                    selectedOperarion.CompleteOperation(splitedInput);
                }
            }
        }
    }
}
