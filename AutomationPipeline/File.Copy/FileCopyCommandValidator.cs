using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Copy
{
    internal class FileCopyCommandValidator : ICommandValidator<FileCopyCommand>
    {
        public static readonly FileCopyCommandValidator Instance = new FileCopyCommandValidator();

        private FileCopyCommandValidator()
        {

        }

        public (bool, string) IsValid(FileCopyCommand command)
        {
            if (command == null)
                return (false, "command is null.");

            if (string.IsNullOrEmpty(command.SourceFile))
                return (false, "source file is null or empty.");

            if (!System.IO.File.Exists(command.SourceFile))
                return (false, $"source file {command.SourceFile} missing.");

            if (string.IsNullOrEmpty(command.DestinationFile))
                return (false, "destination file is null or empty.");

            if (System.IO.File.Exists(command.DestinationFile))
                return (false, $"destination file {command.DestinationFile} missing.");

            return (true, string.Empty);
        }
    }
}