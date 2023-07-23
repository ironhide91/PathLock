using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Delete
{
    internal class FileDeleteCommandExecutor : ICommandExecutor<FileDeleteCommand, ZeroOutput>
    {
        public static readonly FileDeleteCommandExecutor Instance = new FileDeleteCommandExecutor();

        private FileDeleteCommandExecutor()
        {

        }

        public ZeroOutput Execute(FileDeleteCommand command)
        {
            System.IO.File.Delete(command.File);

            return ZeroOutput.Instance;
        }
    }
}