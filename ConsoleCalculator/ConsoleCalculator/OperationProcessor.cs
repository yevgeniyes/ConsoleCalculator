using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class OperationProcessor
    {
        private const string WELCOME_TEXT = "Console Calculator 1.215\nAvailable operations: sum, sub, mult, div\nAvailable variables: int, double\nExample command: sum 3 2.54 18\n";
        private const string ERROR_EMPTY = "Empty command. Available operations: sum, sub, mult, div\n";
        private const string ERROR_WRONG = "Wrong command. Available operations: sum, sub, mult, div. Available variables: int, double\n";
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

                //Checking correctness of numerical data
                double checkValue;
                for (int i = 1; i < splited.Length; i++)
                {
                    if (!double.TryParse(splited[i], NumberStyles.Number, CultureInfo.InvariantCulture, out checkValue))
                    {
                        Console.WriteLine(ERROR_WRONG);
                        Run();
                    }
                }

                switch (operation)
                {
                    case "sum":
                        Console.WriteLine("Result: " + Calculations.Sum(splited) + "\n");
                        break;
                    case "sub":
                        Console.WriteLine("Result: " + Calculations.Subtract(splited) + "\n");
                        break;
                    case "mult":
                        Console.WriteLine("Result: " + Calculations.Multiply(splited) + "\n");
                        break;
                    case "div":
                        Console.WriteLine("Result: " + Calculations.Divide(splited) + "\n");
                        break;
                    default:
                        Console.WriteLine(ERROR_WRONG);
                        break;
                }
            }
        } 
    }
}
