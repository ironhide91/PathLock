using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Create
{
    internal class FolderCreateCommandExecutor : ICommandExecutor<FolderCreateCommand, ZeroOutput>
    {
        public static readonly FolderCreateCommandExecutor Instance = new FolderCreateCommandExecutor();

        private FolderCreateCommandExecutor()
        {

        }

        public ZeroOutput Execute(FolderCreateCommand command)
        {
            var fullPath = Path.Combine(command.DestinationPath, command.FolderName);

            _ = Directory.CreateDirectory(fullPath);

            return ZeroOutput.Instance;
        }
    }
}