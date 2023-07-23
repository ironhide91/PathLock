namespace PathLock.AutomationPipeline.Core
{
    internal class CommandIdentifier : ICommandIdentifier
    {
        public CommandIdentifier(IReadOnlySet<string> knownCommands)
        {
            this.knownCommands = knownCommands;
        }

        public bool TryIdentify(ReadOnlySpan<char> command, out string identifiedCommand)
        {
            identifiedCommand = null;

            if (command.IsEmpty)
                return false;

            var index = command.IndexOf(' ');

            if (index <= 0)
                return false;

            var possibleCommand = command.Slice(0, index).ToString();

            if (knownCommands.Contains(possibleCommand))
            {
                identifiedCommand = possibleCommand;
                return true;
            }

            return false;
        }

        private readonly IReadOnlySet<string> knownCommands;
    }
}