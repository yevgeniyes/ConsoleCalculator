using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class OperationProcessor
    {
        private const string WELCOME_TEXT = "Console Calculator 1.219\nAvailable operations: sum, sub, mult, div\nAvailable variables: int, double\nExample command: sum 3 2.54 18\n";
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

                string[] splited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string operation = splited[0];

                //Checking number of elements in the array
                if (splited.Length < 2)
                {
                    Console.WriteLine(ERROR_WRONG);
                    continue;
                }

                OperationBase choosenOperation = null;

                switch (operation)
                {
                    case "sum":
                        choosenOperation = new SumOperation();
                        break;
                    case "sub":
                        choosenOperation = new SubOperation();
                        break;
                    case "mult":
                        choosenOperation = new MultOperation();
                        break;
                    case "div":
                        choosenOperation = new DivOperation();
                        break;
                    default:
                        Console.WriteLine(ERROR_WRONG);
                        break;
                }

                if (choosenOperation != null && choosenOperation.CheckValues(splited))
                {
                    Console.WriteLine("Result: " + choosenOperation.GetResult(splited) + "\n");
                }
            }
        }
    }
}
