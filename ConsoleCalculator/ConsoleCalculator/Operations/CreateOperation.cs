using System;
using System.IO;

namespace ConsoleCalculator
{
    internal class CreateOperation : FileOperationBase
    {
        private bool fileIsCreated;

        //Checking input correctness
        public override bool Validate(string[] splitedInput)
        {
            if (splitedInput.Length == 2 && splitedInput[1].Contains(@":\")) return true;
            else
            {
                Console.WriteLine(Messages.ERROR_FILE_INVALID);
                return false;
            }
        }

        //Perform create operation
        public override void Execute(string[] splitedInput)
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

            if (fileIsCreated)
                Console.WriteLine("Result: " + file + " was created\n");
        }
    }
}
