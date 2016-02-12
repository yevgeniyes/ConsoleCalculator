using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator 1.00\nAvailable operations: sum(+), sub(-), mult(*), div(/)\nAvailable variables: int, double\nExample command: sum 3 2.54 18\n");
            Calculator();
        }

        static void Calculator()
        {
            Console.WriteLine("Enter the command:");
            string input = Console.ReadLine();
            string errorMessage = "Wrong input operation. Available operations: sum, sub, mult, div\n";
            string invalidDataMessage = "Invalid input data. Available variables: int, double";
            if (input == "") Console.WriteLine(errorMessage);
            else
            {
                string[] splited = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string operation = splited[0];
                double value = 0.0;

                if (operation == "sum")
                {
                    for (int i = 1; i < splited.Length; i++)
                        try
                        {
                            value = value + double.Parse(splited[i], CultureInfo.InvariantCulture);
                        }
                        catch
                        {
                            Console.WriteLine(invalidDataMessage);
                            value = 0;
                            break;
                        }
                }
                if (operation == "sub")
                {
                    try
                    {
                        value = double.Parse(splited[1], CultureInfo.InvariantCulture);
                    }
                    catch
                    {
                        Console.WriteLine(invalidDataMessage);
                    }
                    for (int i = 1; i < splited.Length - 1; i++)
                        try
                        {
                            value = value - double.Parse(splited[i + 1], CultureInfo.InvariantCulture);
                        }
                        catch
                        {
                            Console.WriteLine(invalidDataMessage);
                            value = 0;
                            break;
                        }
                }
                if (operation == "mult")
                {
                    try
                    {
                        value = double.Parse(splited[1], CultureInfo.InvariantCulture);
                    }
                    catch
                    {
                        Console.WriteLine(invalidDataMessage);
                    }
                    for (int i = 1; i < splited.Length - 1; i++)
                        try
                        {
                            value = value * double.Parse(splited[i + 1], CultureInfo.InvariantCulture);
                        }
                        catch
                        {
                            Console.WriteLine(invalidDataMessage);
                            value = 0;
                            break;
                        }
                }
                if (operation == "div")
                {
                    try
                    {
                        value = double.Parse(splited[1], CultureInfo.InvariantCulture);
                    }
                    catch
                    {
                        Console.WriteLine(invalidDataMessage);
                    }
                    for (int i = 1; i < splited.Length - 1; i++)
                        try
                        {
                            value = value / double.Parse(splited[i + 1], CultureInfo.InvariantCulture);
                        }
                        catch
                        {
                            Console.WriteLine(invalidDataMessage);
                            value = 0;
                            break;
                        }
                }
                if (operation != "sum" && operation != "sub" && operation != "mult" && operation != "div")
                    Console.WriteLine(errorMessage);
                else Console.WriteLine("Result: " + value + "\n");
            }
            Calculator();
        }
    }
}
