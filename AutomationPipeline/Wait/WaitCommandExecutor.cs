using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Wait
{
    internal class WaitCommandExecutor : ICommandExecutor<WaitCommand, ZeroOutput>
    {
        public static readonly WaitCommandExecutor Instance = new WaitCommandExecutor();

        private WaitCommandExecutor()
        {

        }

        public ZeroOutput Execute(WaitCommand command)
        {
            Console.WriteLine($"current time {DateTime.Now}");
            Console.WriteLine($"waiting for {command.Seconds} seconds.");
            Thread.Sleep(command.Seconds * 1000);
            Console.WriteLine($"current time {DateTime.Now}");

            return ZeroOutput.Instance;
        }
    }
}