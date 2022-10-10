namespace TextAPI.Models
{
    public class TextSplitResponse
    {
        public TextSplitResponse(int distinctUniqueWords)
        {
            DistinctUniqueWords = distinctUniqueWords;
        }

        public int DistinctUniqueWords { get; internal set; }
    }
}