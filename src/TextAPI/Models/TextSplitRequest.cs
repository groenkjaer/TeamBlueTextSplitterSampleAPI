using System.ComponentModel.DataAnnotations;

namespace TextAPI.Models
{
    public class TextSplitRequest
    {
        public TextSplitRequest(string text)
        {
            Text = text;
        }

        [Required]
        public string Text { get; internal set; }
    }
}