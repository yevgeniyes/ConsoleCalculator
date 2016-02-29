using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal class OperationFabric
    {
        //Method of selecting the operation and tag assignment based on the input data
        public OperationBase SelectOperation(string operation, out string operationTag)
        {
            OperationBase choosenOperation = null;
            operationTag = null;

            switch (operation)
            {
                case "sum":
                    choosenOperation = new SumOperation();
                    operationTag = "math";
                    break;
                case "sub":
                    choosenOperation = new SubOperation();
                    operationTag = "math";
                    break;
                case "mult":
                    choosenOperation = new MultOperation();
                    operationTag = "math";
                    break;
                case "div":
                    choosenOperation = new DivOperation();
                    operationTag = "math";
                    break;
                case "create":
                    choosenOperation = new CreateOperation();
                    operationTag = "file";
                    break;
                case "delete":
                    choosenOperation = new DeleteOperation();
                    operationTag = "file";
                    break;
                case "copy":
                    choosenOperation = new CopyOperation();
                    operationTag = "file";
                    break;
                case "move":
                    choosenOperation = new MoveOperation();
                    operationTag = "file";
                    break;
                default:
                    Console.WriteLine(Messages.ERROR_INVALID_COMMAND);
                    break;
            }
            
            return choosenOperation;
        }
    }
}
