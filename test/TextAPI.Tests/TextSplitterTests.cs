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

        [TestCase("these are distinct. distinct words")]
        [TestCase("these are distinct, distinct words")]
        [TestCase("these are distinct: distinct words")]
        [TestCase("these are distinct; distinct words")]
        public void SplitWordsWithPunctuationCharsTest(string value)
        {
            var distinctWords = textSplitter.SplitIntoDistinctWords(value);
            Assert.That(distinctWords.Count(), Is.EqualTo(4));
        }

        public void SplitAndReadOutput()
        {
            var distinctWords = textSplitter.SplitIntoDistinctWords("First Second").ToList();
            Assert.Multiple(() =>
            {
                Assert.That(distinctWords[0], Is.EqualTo("First"));
                Assert.That(distinctWords[1], Is.EqualTo("Second"));
            });
        }
    }
}