using Microsoft.AspNetCore.Mvc;
using TextAPI.Models;
using TextAPI.Services;

namespace TextAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextController : ControllerBase
    {
        private readonly ITextSplitter textSplitter;

        public TextController(ITextSplitter textSplitter)
        {
            this.textSplitter = textSplitter;
        }

        /// <summary>
        /// Splits the text into unique words
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public TextSplitResponse Split([FromBody] TextSplitRequest request)
        {
            var distinctUniqueWords = textSplitter.SplitIntoDistinctWords(request.Text).Count();
            return new TextSplitResponse(distinctUniqueWords);
        }
    }
}