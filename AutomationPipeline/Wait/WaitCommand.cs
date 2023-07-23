using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Wait
{
    internal class WaitCommand : ICommand<WaitCommand>
    {
        internal WaitCommand(int seconds)
        {
            Seconds = seconds;
        }

        public readonly int Seconds;

        public string Key { get { return key; } }

        public WaitCommand Argument => this;

        public static readonly string key = "Wait";
    }
}