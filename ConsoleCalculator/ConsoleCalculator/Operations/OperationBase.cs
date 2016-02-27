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
                var result = GetResult(splitedInput);
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
                    Console.WriteLine(Messages.ERROR_CALC_INVALID);
                    return false;
                }
            }
            return true;
        }

        //Perform operation: overriden for each Operations class
        public abstract string GetResult(string[] splitedInput);

        //Print result
        public virtual void PrintResult(string result)
        {
            Console.WriteLine("Result: " + result + "\n");
        }
    }
}
