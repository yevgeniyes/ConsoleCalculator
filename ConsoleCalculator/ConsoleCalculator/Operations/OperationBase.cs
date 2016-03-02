using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal abstract class OperationBase
    {
        //Template of operation completion: get result, print result
        public void CompleteOperation(string[] splitedInput)
        {
            Execute(splitedInput);
        }

        //Perform operation: overriden for each Operations type
        public abstract void Execute(string[] splitedInput);

        //Print result
        public virtual void PrintResult(string result)
        {
            Console.WriteLine("Result: " + result + "\n");
        }
    }
}
