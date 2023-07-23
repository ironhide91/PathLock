using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Delete
{
    internal class FileDeleteCommandValidator : ICommandValidator<FileDeleteCommand>
    {
        public static readonly FileDeleteCommandValidator Instance = new FileDeleteCommandValidator();

        private FileDeleteCommandValidator()
        {

        }

        public (bool, string) IsValid(FileDeleteCommand command)
        {
            if (command == null)
                return (false, "command is null.");

            if (string.IsNullOrEmpty(command.File))
                return (false, "source file is null or empty.");

            if (!System.IO.File.Exists(command.File))
                return (false, $"source file {command.File} missing.");

            return (true, string.Empty);
        }
    }
}