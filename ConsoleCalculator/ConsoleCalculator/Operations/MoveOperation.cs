using System;
using System.IO;

namespace ConsoleCalculator
{
    class MoveOperation : OperationBase
    {
        private bool fileIsMoved;

        //Checking input correctness
        public override bool CheckValues(string[] splitedInput)
        {
            if (splitedInput.Length == 3 && splitedInput[1].Contains(@":\") && splitedInput[2].Contains(@":\"))
                return true;
            else
            {
                Console.WriteLine(Messages.ERROR_FILE_INVALID);
                return false;
            }
        }

        //Perform move operation
        public override string GetResult(string[] splitedInput)
        {
            string file = splitedInput[1];
            string movedFile = splitedInput[2];
            fileIsMoved = false;

            try
            {
                File.Move(file, movedFile);
                fileIsMoved = true;
            }
            catch
            {
                Console.WriteLine(Messages.ERROR_FILE_CREATE_FAIL);
            }

            return file;
        }

        //Print result
        public override void PrintResult(string result)
        {
            if (fileIsMoved)
                Console.WriteLine("Result: " + result + " was moved\n");
        }
    }
}
