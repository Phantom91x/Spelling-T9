using System;

namespace Spelling.Common.Exceptions
{
    public class WrongFileFormatException : Exception
    {
        public override string ToString()
        {
            return "Wrong input file format";
        }
    }
}