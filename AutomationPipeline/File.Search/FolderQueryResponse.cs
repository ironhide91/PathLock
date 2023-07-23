using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Search
{
    internal class TextFileSearchResponse : Response<int>
    {
        public TextFileSearchResponse(int value) : base(value)
        {

        }
    }
}