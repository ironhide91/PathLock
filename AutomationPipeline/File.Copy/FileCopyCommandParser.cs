using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Copy
{
    internal class FileCopyCommandParser : ICommandParser<FileCopyCommand>
    {
        public static readonly FileCopyCommandParser Instance = new FileCopyCommandParser();

        private FileCopyCommandParser()
        {

        }

        public bool TryParse(string stringCommand, out FileCopyCommand command)
        {
            command = null;

            if (string.IsNullOrEmpty(stringCommand))
                return false;

            var arguments = stringCommand.Split(' ');

            if (arguments.Length != 3)
                return false;

            if (string.IsNullOrEmpty(arguments[1]))
                return false;

            if (string.IsNullOrEmpty(arguments[2]))
                return false;

            command = new FileCopyCommand(sourceFile: arguments[1], destinationFile: arguments[2]);

            return true;
        }
    }
}