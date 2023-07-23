using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Query
{
    internal class FolderQueryCommandExecutor : ICommandExecutor<FolderQueryCommand, FolderQueryResponse>
    {
        public static readonly FolderQueryCommandExecutor Instance = new FolderQueryCommandExecutor();

        private FolderQueryCommandExecutor()
        {

        }

        public FolderQueryResponse Execute(FolderQueryCommand command)
        {
            var files = Directory.GetFiles(command.Folder).AsReadOnly();

            return new FolderQueryResponse(files);
        }
    }
}