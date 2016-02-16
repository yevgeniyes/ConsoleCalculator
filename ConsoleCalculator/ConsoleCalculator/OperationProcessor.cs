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
                bool isBreak = false;
                for (int i = 1; i < splited.Length; i++)
                {
                    if (!double.TryParse(splited[i], NumberStyles.Number, CultureInfo.InvariantCulture, out checkValue))
                    {
                        Console.WriteLine(ERROR_WRONG);
                        isBreak = true;
                        break;
                    }
                }
                if (!isBreak)
                {
                    switch (operation)
                    {
                        case "sum":
                            var sum = new CalculateSum();
                            Console.WriteLine("Result: " + sum.GetResult(splited) + "\n");
                            break;
                        case "sub":
                            var sub = new CalculateSub();
                            Console.WriteLine("Result: " + sub.GetResult(splited) + "\n");
                            break;
                        case "mult":
                            var mult = new CalculateMult();
                            Console.WriteLine("Result: " + mult.GetResult(splited) + "\n");
                            break;
                        case "div":
                            var div = new CalculateDiv();
                            Console.WriteLine("Result: " + div.GetResult(splited) + "\n");
                            break;
                        default:
                            Console.WriteLine(ERROR_WRONG);
                            break;
                    }
                }
                
                
            }
        }
    }
}
