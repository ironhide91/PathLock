using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Create
{
    internal class FolderCreateCommandValidator : ICommandValidator<FolderCreateCommand>
    {
        public static readonly FolderCreateCommandValidator Instance = new FolderCreateCommandValidator();

        private FolderCreateCommandValidator()
        {

        }

        public (bool, string) IsValid(FolderCreateCommand command)
        {
            if (command == null)
                return (false, "command is null.");

            if (string.IsNullOrEmpty(command.DestinationPath))
                return (false, "destination file is null or empty.");

            if (!Directory.Exists(command.DestinationPath))
                return (false, $"destination file {command.DestinationPath} missing.");

            if (string.IsNullOrEmpty(command.FolderName))
                return (false, "folder name is null or empty.");

            return (true, string.Empty);
        }
    }
}