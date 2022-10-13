using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAPI.Services;

namespace TextAPI.Tests
{
    public class TextSplitterRegexTests
    {
        private ITextSplitter regexSplitter;

        [SetUp]
        public void Setup()
        {
            regexSplitter = new TextSplitterRegex();
        }

        [Test]
        public void SplitUniqueWords()
        {
            var uniqueWords = regexSplitter.SplitIntoDistinctWords("a.horse,and;a2dog");
            Assert.That(uniqueWords.Count(), Is.EqualTo(4));
        }
    }
}
