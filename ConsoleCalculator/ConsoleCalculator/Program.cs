using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class Program
    {
        private const string WELCOME_TEXT = "Console Calculator 1.00\nAvailable operations: sum(+), sub(-), mult(*), div(/)\nAvailable variables: int, double\nExample command: sum 3 2.54 18\n";
        private const string ERROR_EMPTY = "Empty command. Available operations: sum, sub, mult, div\n";
        private const string ERROR_WRONG = "Wrong command. Available operations: sum, sub, mult, div. Available variables: int, double\n";

        static void Main(string[] args)
        {
            Console.WriteLine(WELCOME_TEXT);
            Calculator();
        }

        static void Calculator()
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
                        Calculator();
                    }
                }

                    switch (operation)
                    {
                        case "sum":
                            Calculations(splited, "sum");
                            break;
                        case "sub":
                            Calculations(splited, "sub");
                            break;
                        case "mult":
                            Calculations(splited, "mult");
                            break;
                        case "div":
                            Calculations(splited, "div");
                            break;
                        default:
                        Console.WriteLine(ERROR_WRONG);
                        break;
                    }
            } 
        }

        static void Calculations(string[] splitedString, string choosenOperation)
        {
            double value = double.Parse(splitedString[1], CultureInfo.InvariantCulture);

            switch (choosenOperation)
            {
                case "sum":
                    for (int i = 1; i < splitedString.Length - 1; i++)
                    {
                        value = value + double.Parse(splitedString[i + 1], CultureInfo.InvariantCulture);
                    }
                    break;
                case "sub":
                    for (int i = 1; i < splitedString.Length - 1; i++)
                    {
                        value = value - double.Parse(splitedString[i + 1], CultureInfo.InvariantCulture);
                    }
                    break;
                case "mult":
                    for (int i = 1; i < splitedString.Length - 1; i++)
                    {
                        value = value * double.Parse(splitedString[i + 1], CultureInfo.InvariantCulture);
                    }
                    break;
                case "div":
                    for (int i = 1; i < splitedString.Length - 1; i++)
                    {
                        value = value / double.Parse(splitedString[i + 1], CultureInfo.InvariantCulture);
                    }
                    break;
            }
            Console.WriteLine("Result: " + value + "\n");
        }
    }
}
