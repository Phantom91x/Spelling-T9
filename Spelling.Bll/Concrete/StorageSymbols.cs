using System.Collections.Generic;
using Spelling.Common.Exceptions;
using Spelling.Common.Models;

namespace Spelling.Bll
{
    /// <summary>
    /// Storage symbols
    /// </summary>
    internal static class StorageSymbols
    {
        private static Dictionary<char, SymbolModel> Collection { get; }

        static StorageSymbols()
        {
            Collection = new Dictionary<char, SymbolModel>
            {
                {'a', new SymbolModel('2', 1)},
                {'b', new SymbolModel('2', 2)},
                {'c', new SymbolModel('2', 3)},

                {'d', new SymbolModel('3', 1)},
                {'e', new SymbolModel('3', 2)},
                {'f', new SymbolModel('3', 3)},

                {'g', new SymbolModel('4', 1)},
                {'h', new SymbolModel('4', 2)},
                {'i', new SymbolModel('4', 3)},

                {'j', new SymbolModel('5', 1)},
                {'k', new SymbolModel('5', 2)},
                {'l', new SymbolModel('5', 3)},

                {'m', new SymbolModel('6', 1)},
                {'n', new SymbolModel('6', 2)},
                {'o', new SymbolModel('6', 3)},

                {'p', new SymbolModel('7', 1)},
                {'q', new SymbolModel('7', 2)},
                {'r', new SymbolModel('7', 3)},
                {'s', new SymbolModel('7', 4)},

                {'t', new SymbolModel('8', 1)},
                {'u', new SymbolModel('8', 2)},
                {'v', new SymbolModel('8', 3)},

                {'w', new SymbolModel('9', 1)},
                {'x', new SymbolModel('9', 2)},
                {'y', new SymbolModel('9', 3)},
                {'z', new SymbolModel('9', 4)},
                {' ', new SymbolModel('0', 1)}
            };
        }

        public static SymbolModel GetSymbolByLetter(char letter)
        {
            if (Collection[letter] == null) throw new NotSupportedCharException(letter);
            return Collection[letter];
        }
    }
}