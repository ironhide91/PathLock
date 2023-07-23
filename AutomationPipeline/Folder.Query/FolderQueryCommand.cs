using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Query
{
    internal class FolderQueryCommand : ICommand<FolderQueryCommand>
    {
        internal FolderQueryCommand(string folder)
        {
            Folder = folder;
        }

        public readonly string Folder;

        public string Key { get { return key; } }

        public FolderQueryCommand Argument => this;

        public static readonly string key = "Folder.Query";
    }
}