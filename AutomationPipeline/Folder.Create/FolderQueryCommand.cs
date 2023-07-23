using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Create
{
    internal class FolderCreateCommand : ICommand<FolderCreateCommand>
    {
        internal FolderCreateCommand(string destinationPath, string folderName)
        {
            DestinationPath = destinationPath;
            FolderName = folderName;
        }

        public readonly string DestinationPath;
        public readonly string FolderName;

        public string Key { get { return key; } }

        public FolderCreateCommand Argument => this;

        public static readonly string key = "Folder.Create";
    }
}