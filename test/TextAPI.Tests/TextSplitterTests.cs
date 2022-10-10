using TextAPI.Services;

namespace TextAPI.Tests
{
    public class TextSplitterTests
    {
        private ITextSplitter textSplitter;

        [SetUp]
        public void Setup()
        {
            textSplitter = new TextSplitter();
        }

        [Test]
        public void UniqueWordsTest()
        {
            var distinctWords = textSplitter.SplitIntoDistinctWords("a horse and a dog");
            Assert.That(distinctWords.Count(), Is.EqualTo(4));
        }
    }
}