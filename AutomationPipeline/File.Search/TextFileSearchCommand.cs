using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Search
{
    internal class TextFileSearchCommand : ICommand<TextFileSearchCommand>
    {
        internal TextFileSearchCommand(string sourceFile, string searchTerm)
        {
            SourceFile = sourceFile;
            SearchTerm = searchTerm;
        }

        public readonly string SourceFile;
        public readonly string SearchTerm;

        public string Key { get { return key; } }

        public TextFileSearchCommand Argument => this;

        public static readonly string key = "File.Search";
    }
}