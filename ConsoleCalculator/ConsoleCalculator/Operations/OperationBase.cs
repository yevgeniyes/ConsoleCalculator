using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class OperationBase
    {
        public void CompleteOperation(string[] splited)
        {
            if (CheckValues(splited))
                Console.WriteLine("Result: " + GetResult(splited) + "\n");
        }

        //Checking correctness of numerical data
        public virtual bool CheckValues(string[] splited)
        {
            double checkedValue;

            for (int i = 1; i < splited.Length; i++)
            {
                if (!double.TryParse(splited[i], NumberStyles.Number, CultureInfo.InvariantCulture, out checkedValue))
                {
                    Console.WriteLine(OperationProcessor.ERROR_WRONG);
                    return false;
                }
            }
                return true;
        }

        public abstract double GetResult(string[] splited);
    }
}
