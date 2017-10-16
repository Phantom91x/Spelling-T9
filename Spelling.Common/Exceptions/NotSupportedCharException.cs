using System;

namespace Spelling.Common.Exceptions
{
    public class NotSupportedCharException : Exception
    {
        public NotSupportedCharException(char symbol)
        {
            Symbol = symbol;
        }

        public char Symbol { get; private set; }

        public override string ToString()
        {
            return $"Not supported symbol '{Symbol}'";
        }
    }
}