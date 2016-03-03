using System;
using System.Globalization;

namespace ConsoleCalculator
{
    /// <summary>
    /// The base class for all operations
    /// </summary>
    internal abstract class OperationBase
    {
        /// <summary>
        /// Template of operation completion
        /// </summary>
        /// <param name="splitedInput"></param>
        public void CompleteOperation(string[] splitedInput)
        {
            if(Validate(splitedInput))
                Execute(splitedInput);
        }

        //Validate input
        protected abstract bool Validate(string[] splitedInput);

        //Perform operation: overriden for each Operation
        protected abstract void Execute(string[] splitedInput);
    }
}
