namespace TextAPI.Services
{
    public class TextSplitter : ITextSplitter
    {
        public IEnumerable<string> SplitIntoDistinctWords(string text)
        {
            return text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct();
        }
    }
}
