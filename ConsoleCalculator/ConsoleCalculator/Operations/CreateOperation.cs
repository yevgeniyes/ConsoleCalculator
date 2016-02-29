using System;
using System.IO;

namespace ConsoleCalculator
{
    internal class CreateOperation : OperationBase
    {
        private bool fileIsCreated;

        //Checking input correctness
        public override bool CheckStrings(string[] splitedInput)
        {
            if (splitedInput.Length == 2 && splitedInput[1].Contains(@":\")) return true;
            else
            {
                Console.WriteLine(Messages.ERROR_FILE_INVALID);
                return false;
            }
        }

        //Perform create operation
        public override string GetResult(string[] splitedInput)
        {
            string file = splitedInput[1];
            fileIsCreated = false;

            try
            {
                File.Create(file);
                fileIsCreated = true;
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
            if (fileIsCreated)
                Console.WriteLine("Result: " + result + " was created\n");
        }
    }
}
