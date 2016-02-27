using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class OperationProcessor
    {
        public OperationProcessor()
        {
            Console.WriteLine(Messages.INTRO_TEXT);
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
