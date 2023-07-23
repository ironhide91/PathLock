using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Query
{
    internal class FolderQueryCommandValidator : ICommandValidator<FolderQueryCommand>
    {
        public static readonly FolderQueryCommandValidator Instance = new FolderQueryCommandValidator();

        private FolderQueryCommandValidator()
        {

        }

        public (bool, string) IsValid(FolderQueryCommand command)
        {
            if (command == null)
                return (false, "command is null.");

            if (string.IsNullOrEmpty(command.Folder))
                return (false, "folder name is null or empty.");

            if (!Directory.Exists(command.Folder))
                return (false, $"folder {command.Folder} missing.");

            return (true, string.Empty);
        }
    }
}