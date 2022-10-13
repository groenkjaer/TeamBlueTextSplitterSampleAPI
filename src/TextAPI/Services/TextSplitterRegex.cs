using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextAPI.Services
{
    public class TextSplitterRegex : ITextSplitter
    {
        private Regex Regex { get; init; }

        public TextSplitterRegex()
        {
            Regex = new(@"\w+");
        }

        public IEnumerable<string> SplitIntoDistinctWords(string text)
        {
            return Regex.Matches(text).Select(m => m.Value).Distinct();
        }
    }
}
