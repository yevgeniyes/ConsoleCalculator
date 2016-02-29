using System;

namespace ConsoleCalculator
{
    //Text messages and errors
    internal static class Messages
    {
        public const string INTRO_TEXT = "Console Calculator 1.301\n\nAvailable operations for calculator: sum, sub, mult, div. Available variables: int, double\nExample command: sum 3 2.54 18\n\nAvailable operations for files: create, delete, copy, move\nExample command: create C:\\New\\SomeFile.txt\n";
        public const string ERROR_EMPTY_COMMAND = "Empty command. Enter the command and try again\n";
        public const string ERROR_CALC_INVALID = "Invalid command. Available operations: sum, sub, mult, div.\nAvailable variables: int, double\n";
        public const string ERROR_FILE_INVALID = "Invalid command. Available operations: create, delete, copy, move.\nFile path example: C:\\New\\SomeFile.txt\n";
        public const string ERROR_INVALID_COMMAND = "Invalid command. Check the input data and try again\n";
        public const string ERROR_FILE_DEL_FAIL = "Directory not found or file does not exist. Check path and try again\n";
        public const string ERROR_FILE_CREATE_FAIL = "Directory not found or file already exist. Check path and try again\n";
        public const string ERROR_CRITICAL = "Critical error. Please restart application and try again.\n";
    }
}
