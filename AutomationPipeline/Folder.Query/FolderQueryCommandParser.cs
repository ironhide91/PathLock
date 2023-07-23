using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Query
{
    internal class FolderQueryCommandParser : ICommandParser<FolderQueryCommand>
    {
        public static readonly FolderQueryCommandParser Instance = new FolderQueryCommandParser();

        private FolderQueryCommandParser()
        {

        }

        public bool TryParse(string stringCommand, out FolderQueryCommand command)
        {
            command = null;

            if (string.IsNullOrEmpty(stringCommand))
                return false;

            var arguments = stringCommand.Split(' ');

            if (arguments.Length != 2)
                return false;

            if (string.IsNullOrEmpty(arguments[1]))
                return false;

            command = new FolderQueryCommand(folder: arguments[1]);

            return true;
        }
    }
}