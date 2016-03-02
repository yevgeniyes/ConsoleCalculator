using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal class SubOperation : MathOperationBase
    {
        //Perform subtraction operation
        protected override void Execute(string[] splitedInput)
        {
            double value = double.Parse(splitedInput[1], CultureInfo.InvariantCulture);

            for (int i = 1; i < splitedInput.Length - 1; i++)
            {
                value = value - double.Parse(splitedInput[i + 1], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Result: " + value + "\n");
        }
    }
}
