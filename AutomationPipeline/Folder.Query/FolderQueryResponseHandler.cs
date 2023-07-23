using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Query
{
    internal class FolderQueryResponseHandler : IResponseHandler<FolderQueryResponse>
    {
        public static readonly FolderQueryResponseHandler Instance = new FolderQueryResponseHandler();

        private FolderQueryResponseHandler()
        {

        }

        public void Handle(FolderQueryResponse response)
        {
            foreach (var item in response.Value)
                Console.WriteLine(item);
        }
    }
}