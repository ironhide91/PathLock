using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Download
{
    internal class FileDownloadCommandParser : ICommandParser<FileDownloadCommand>
    {
        public static readonly FileDownloadCommandParser Instance = new FileDownloadCommandParser();

        private FileDownloadCommandParser()
        {

        }

        public bool TryParse(string stringCommand, out FileDownloadCommand command)
        {
            command = null;

            if (string.IsNullOrEmpty(stringCommand))
                return false;

            var arguments = stringCommand.Split(' ');

            if (arguments.Length != 3)
                return false;

            if (string.IsNullOrEmpty(arguments[1]))
                return false;

            command = new FileDownloadCommand(url: arguments[1], path: arguments[2]);

            return true;
        }
    }
}