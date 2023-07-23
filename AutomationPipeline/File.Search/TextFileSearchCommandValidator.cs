using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Search
{
    internal class TextFileSearchCommandValidator : ICommandValidator<TextFileSearchCommand>
    {
        public static readonly TextFileSearchCommandValidator Instance = new TextFileSearchCommandValidator();

        private TextFileSearchCommandValidator()
        {

        }

        public (bool, string) IsValid(TextFileSearchCommand command)
        {
            if (command == null)
                return (false, "command is null.");

            if (string.IsNullOrEmpty(command.SourceFile))
                return (false, "source file is null or empty.");

            if (!System.IO.File.Exists(command.SourceFile))
                return (false, $"source file {command.SourceFile} missing.");

            if (string.IsNullOrEmpty(command.SearchTerm))
                return (false, "search term is null or empty.");

            return (true, string.Empty);
        }
    }
}