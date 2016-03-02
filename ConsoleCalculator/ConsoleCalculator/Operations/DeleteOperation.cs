using System;
using System.IO;

namespace ConsoleCalculator
{
    internal class DeleteOperation : FileOperationBase
    {
        private bool fileIsDeleted;

        //Checking input correctness
        protected override bool Validate(string[] splitedInput)
        {
            if (splitedInput.Length == 2 && splitedInput[1].Contains(@":\")) return true;
            else
            {
                Console.WriteLine(Messages.ERROR_FILE_INVALID);
                return false;
            }
        }

        //Perform delete operation
        protected override void Execute(string[] splitedInput)
        {
            string file = splitedInput[1];
            fileIsDeleted = false;

            try
            {
                File.Delete(file);
                fileIsDeleted = true;
            }
            catch
            {
                Console.WriteLine(Messages.ERROR_FILE_DEL_FAIL);
            }

            if (fileIsDeleted)
                Console.WriteLine("Result: " + file + " was deleted\n");
        }
    }
}
