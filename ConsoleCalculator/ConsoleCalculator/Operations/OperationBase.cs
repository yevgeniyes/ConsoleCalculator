using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class OperationBase
    {
        //Template of operation completion: check input, get result, print result
        public void CompleteOperation(string[] splitedInput)
        {
            if (CheckValues(splitedInput))
            {
                double result = GetResult(splitedInput);
                PrintResult(result);
            }
        }

        //Checking input correctness
        public virtual bool CheckValues(string[] splitedInput)
        {
            double checkedValue;

            for (int i = 1; i < splitedInput.Length; i++)
            {
                if (!double.TryParse(splitedInput[i], NumberStyles.Number, CultureInfo.InvariantCulture, out checkedValue))
                {
                    Console.WriteLine(OperationProcessor.ERROR_WRONG);
                    return false;
                }
            }
            return true;
        }

        //Perform math operation: overriden for each Operations class
        public abstract double GetResult(string[] splitedInput);

        //Print result
        public virtual void PrintResult(double result)
        {
            Console.WriteLine("Result: " + result + "\n");
        }
    }
}
