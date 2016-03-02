﻿using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal abstract class OperationBase
    {
        //Template of operation completion
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
