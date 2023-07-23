using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Search
{
    internal class TextFileSearchResponseHandler : IResponseHandler<TextFileSearchResponse>
    {
        public static readonly TextFileSearchResponseHandler Instance = new TextFileSearchResponseHandler();

        private TextFileSearchResponseHandler()
        {

        }

        public void Handle(TextFileSearchResponse response)
        {
            Console.WriteLine($"match found {response.Value}.");
            Console.WriteLine("success.");
        }
    }
}