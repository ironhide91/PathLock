using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Create
{
    internal class FolderCreateResponseHandler : IResponseHandler<ZeroOutput>
    {
        public static readonly FolderCreateResponseHandler Instance = new FolderCreateResponseHandler();

        private FolderCreateResponseHandler()
        {

        }

        public void Handle(ZeroOutput _)
        {
            Console.WriteLine("success");
        }
    }
}