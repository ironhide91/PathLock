using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Wait
{
    internal class WaitResponseHandler : IResponseHandler<ZeroOutput>
    {
        public static readonly WaitResponseHandler Instance = new WaitResponseHandler();

        private WaitResponseHandler()
        {

        }

        public void Handle(ZeroOutput _)
        {
            Console.WriteLine("success");
        }
    }
}