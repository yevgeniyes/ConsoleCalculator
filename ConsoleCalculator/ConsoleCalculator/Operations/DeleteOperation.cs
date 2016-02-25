using System;
using System.IO;

namespace ConsoleCalculator
{
    class DeleteOperation : OperationBase
    {
        private bool fileIsDeleted;

        //Checking input correctness
        public override bool CheckValues(string[] splitedInput)
        {
            if (splitedInput.Length == 2 && splitedInput[1].Contains(@":\")) return true;
            else
            {
                Console.WriteLine(OperationProcessor.ERROR_FILE_WRONG);
                return false;
            }
        }

        //Perform delete operation
        public override string GetResult(string[] splitedInput)
        {
            string path = splitedInput[1];
            fileIsDeleted = false;

            try
            {
                File.Delete(path);
                fileIsDeleted = true;
            }
            catch
            {
                Console.WriteLine("Directory not found or file does not exist. Check path and try again\n");
            }

            return path;
        }

        //Print result
        public override void PrintResult(string result)
        {
            if (fileIsDeleted)
                Console.WriteLine("Result: " + result + " was deleted\n");
        }
    }
}
