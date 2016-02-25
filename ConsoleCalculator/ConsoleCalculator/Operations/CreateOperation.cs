using System;
using System.IO;

namespace ConsoleCalculator
{
    class CreateOperation : OperationBase
    {
        private bool fileIsCreated;

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

        //Perform create operation
        public override string GetResult(string[] splitedInput)
        {
            string path = splitedInput[1];
            fileIsCreated = false;

            try
            {
                File.Create(path);
                fileIsCreated = true;
            }
            catch
            {
                Console.WriteLine("Directory not found or file already exist. Check path and try again\n");
            }

            return path;
        }

        //Print result
        public override void PrintResult(string result)
        {
            if (fileIsCreated)
                Console.WriteLine("Result: " + result + " was created\n");
        }
    }
}
