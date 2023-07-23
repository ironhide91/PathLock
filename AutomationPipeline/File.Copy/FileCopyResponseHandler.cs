using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Copy
{
    internal class FileCopyResponseHandler : IResponseHandler<ZeroOutput>
    {
        public static readonly FileCopyResponseHandler Instance = new FileCopyResponseHandler();

        private FileCopyResponseHandler()
        {

        }

        public void Handle(ZeroOutput _)
        {
            Console.WriteLine("success");
        }
    }
}