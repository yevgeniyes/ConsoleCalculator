using System;
using System.IO;

namespace ConsoleCalculator
{
    internal class DeleteOperation : FileOperationBase
    {
        private bool fileIsDeleted;

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

        //Perform delete operation
        public override string GetFileResult(string[] splitedInput)
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

            return file;
        }

        //Print result
        public override void PrintResult(string result)
        {
            if (fileIsDeleted)
                Console.WriteLine("Result: " + result + " was deleted\n");
        }
    }
}
