using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Copy
{
    internal class FileCopyCommandExecutor : ICommandExecutor<FileCopyCommand, ZeroOutput>
    {
        public static readonly FileCopyCommandExecutor Instance = new FileCopyCommandExecutor();

        private FileCopyCommandExecutor()
        {

        }

        public ZeroOutput Execute(FileCopyCommand command)
        {
            System.IO.File.Copy(sourceFileName: command.SourceFile, destFileName: command.DestinationFile);

            return ZeroOutput.Instance;
        }
    }
}