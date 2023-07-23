using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Wait
{
    internal class WaitCommandValidator : ICommandValidator<WaitCommand>
    {
        public static readonly WaitCommandValidator Instance = new WaitCommandValidator();

        private WaitCommandValidator()
        {

        }

        public (bool, string) IsValid(WaitCommand command)
        {
            if (command == null)
                return (false, "command is null.");

            return (true, string.Empty);
        }
    }
}