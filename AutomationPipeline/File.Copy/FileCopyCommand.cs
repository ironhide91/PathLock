using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Copy
{
    internal class FileCopyCommand : ICommand<FileCopyCommand>
    {
        internal FileCopyCommand(string sourceFile, string destinationFile)
        {
            SourceFile = sourceFile;
            DestinationFile = destinationFile;
        }

        public readonly string SourceFile;
        public readonly string DestinationFile;

        public string Key { get { return key; } }

        public FileCopyCommand Argument => this;

        public static readonly string key = "File.Copy";
    }
}