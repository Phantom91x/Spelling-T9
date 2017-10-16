using System;
using System.Linq;
using Spelling.Bll.Abstract;
using Spelling.Common.Exceptions;
using Spelling.Common.Models;

namespace Spelling.Bll.Helpers
{
    /// <summary>
    /// Helper for convert text to numbers
    /// </summary>
    public class TextToNumbersHelper : ITextToNumbersHelper
    {
        private string WordToNumbers(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return "";
            }

            SymbolModel lastSymbol = null;
            var result = "";
            foreach (var symbol in word.ToLowerInvariant())
            {
                var symbolRes = StorageSymbols.GetSymbolByLetter(symbol);
                if (lastSymbol?.Number == symbolRes.Number)
                {
                    result += " ";
                }
                result += $"{symbolRes.GetStringNumbers()}";
                lastSymbol = symbolRes;
            }
            return result;
        }

        public string TextToNumbers(string text)
        {
            try
            {
                var words = text.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None).Where(t => t.Length > 0)
                    .ToArray();
                var countWords = Convert.ToInt32(words[0]);
                if (countWords != words.Length - 1) throw new WrongCountWordsException(countWords, words.Length - 1);
                var result = "";
                for (var i = 1; i < words.Length; i++)
                {
                    if (i > 1) result += "\n";
                    result += $"Case #{i}: {WordToNumbers(words[i])}";
                }
                return result;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                throw new WrongFileFormatException();
            }
        }
    }
}