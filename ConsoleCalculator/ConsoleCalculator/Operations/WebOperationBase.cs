using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    abstract class WebOperationBase : OperationBase
    {
        protected override bool Validate(string[] splitedInput)
        {
            if (splitedInput.Length == 2)
                return true;
            else
            {
                Console.WriteLine(Messages.ERROR_FILE_INVALID);
                return false;
            }
        }
    }
}
