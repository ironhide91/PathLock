using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Download
{
    internal class FileDownloadCommandValidator : ICommandValidator<FileDownloadCommand>
    {
        public static readonly FileDownloadCommandValidator Instance = new FileDownloadCommandValidator();

        private FileDownloadCommandValidator()
        {

        }

        public (bool, string) IsValid(FileDownloadCommand command)
        {
            if (command == null)
                return (false, "command is null.");

            if (string.IsNullOrEmpty(command.Url))
                return (false, "url is null or empty.");

            if (string.IsNullOrEmpty(command.Path))
                return (false, "path is null or empty.");

            if (!Directory.Exists(command.Path))
                return (false, $"pathh is missing.");

            return (true, string.Empty);
        }
    }
}