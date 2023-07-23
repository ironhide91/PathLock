using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Download
{
    internal class FileDownloadResponseHandler : IResponseHandler<ZeroOutput>
    {
        public static readonly FileDownloadResponseHandler Instance = new FileDownloadResponseHandler();

        private FileDownloadResponseHandler()
        {

        }

        public void Handle(ZeroOutput _)
        {
            Console.WriteLine("success");
        }
    }
}