using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Delete
{
    internal class FileDeleteCommand : ICommand<FileDeleteCommand>
    {
        internal FileDeleteCommand(string file)
        {
            this.File = file;
        }

        public readonly string File;

        public string Key { get { return key; } }

        public FileDeleteCommand Argument => this;

        public static readonly string key = "File.Delete";
    }
}