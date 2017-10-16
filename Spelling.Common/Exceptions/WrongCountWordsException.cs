using System;

namespace Spelling.Common.Exceptions
{
    public class WrongCountWordsException : Exception
    {
        public WrongCountWordsException(int expectedCount, int actualCount)
        {
            ExpectedCount = expectedCount;
            ActualCount = actualCount;
        }

        public int ExpectedCount { get; private set; }
        public int ActualCount { get; private set; }

        public override string ToString()
        {
            return "Wrong count words";
        }
    }
}