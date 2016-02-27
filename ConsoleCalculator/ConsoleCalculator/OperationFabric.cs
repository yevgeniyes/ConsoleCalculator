using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class OperationFabric
    {
        //Method of selecting the operation based on the input 
        public OperationBase SelectOperation(string operation)
        {
            OperationBase choosenOperation = null;

            switch (operation)
            {
                case "sum":
                    choosenOperation = new SumOperation();
                    break;
                case "sub":
                    choosenOperation = new SubOperation();
                    break;
                case "mult":
                    choosenOperation = new MultOperation();
                    break;
                case "div":
                    choosenOperation = new DivOperation();
                    break;
                case "create":
                    choosenOperation = new CreateOperation();
                    break;
                case "delete":
                    choosenOperation = new DeleteOperation();
                    break;
                case "copy":
                    choosenOperation = new CopyOperation();
                    break;
                case "move":
                    choosenOperation = new MoveOperation();
                    break;
                default:
                    Console.WriteLine(Messages.ERROR_INVALID_COMMAND);
                    break;
            }

            return choosenOperation;
        }
    }
}
