using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class OperationBase
    {
        public abstract double GetResult(string[] splitedString);
    }
}
