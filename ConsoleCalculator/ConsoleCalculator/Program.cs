using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class Program
    {
        private const string WELCOME_TEXT = "Console Calculator 1.00\nAvailable operations: sum(+), sub(-), mult(*), div(/)\nAvailable variables: int, double\nExample command: sum 3 2.54 18\n";
        private const string ERROR_OPERATION = "Wrong operation. Available operations: sum, sub, mult, div\n";
        private const string ERROR_DATA = "Invalid data. Available variables: int, double";

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

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(ERROR_OPERATION);
                    continue;
                }
                
                string[] splited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string operation = splited[0];
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
                        Console.WriteLine(ERROR_OPERATION);
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
