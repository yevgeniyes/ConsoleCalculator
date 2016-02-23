using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class OperationBase
    {
        public void CompleteOperation(string[] splitedInput)
        {
            if (CheckValues(splitedInput))
                Console.WriteLine("Result: " + GetResult(splitedInput) + "\n");
        }

        //Checking correctness of numerical data
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

        public abstract double GetResult(string[] splitedInput);
    }
}
