using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Create
{
    internal class FolderCreateCommandParser : ICommandParser<FolderCreateCommand>
    {
        public static readonly FolderCreateCommandParser Instance = new FolderCreateCommandParser();

        private FolderCreateCommandParser()
        {

        }

        public bool TryParse(string stringCommand, out FolderCreateCommand command)
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

            command = new FolderCreateCommand(destinationPath: arguments[1], folderName: arguments[2]);

            return true;
        }
    }
}