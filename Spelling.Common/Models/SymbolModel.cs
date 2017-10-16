namespace Spelling.Common.Models
{
    public class SymbolModel
    {
        public int CountClicks { get; set; }
        public char Number { get; set; }

        public SymbolModel(char number, int countClicks)
        {
            Number = number;
            CountClicks = countClicks;
        }

        public string GetStringNumbers()
        {
            var result = "";
            for (var i = 0; i < CountClicks; i++)
            {
                result += $"{Number}";
            }
            return result;
        }
    }
}