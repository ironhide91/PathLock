using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Delete
{
    internal class FileDeleteCommandParser : ICommandParser<FileDeleteCommand>
    {
        public static readonly FileDeleteCommandParser Instance = new FileDeleteCommandParser();

        private FileDeleteCommandParser()
        {

        }

        public bool TryParse(string stringCommand, out FileDeleteCommand command)
        {
            command = null;

            if (string.IsNullOrEmpty(stringCommand))
                return false;

            var arguments = stringCommand.Split(' ');

            if (arguments.Length != 2)
                return false;

            if (string.IsNullOrEmpty(arguments[1]))
                return false;

            command = new FileDeleteCommand(file: arguments[1]);

            return true;
        }
    }
}