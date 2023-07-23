using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Delete
{
    internal class FileDeleteResponseHandler : IResponseHandler<ZeroOutput>
    {
        public static readonly FileDeleteResponseHandler Instance = new FileDeleteResponseHandler();

        private FileDeleteResponseHandler()
        {

        }

        public void Handle(ZeroOutput _)
        {
            Console.WriteLine("success");
        }
    }
}