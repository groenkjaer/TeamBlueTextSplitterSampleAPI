namespace TextAPI.Services
{
    public interface ITextSplitter
    {
        IEnumerable<string> SplitIntoDistinctWords(string text);
    }
}
