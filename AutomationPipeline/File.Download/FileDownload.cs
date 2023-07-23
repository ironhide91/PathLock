using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Download
{
    internal class FileDownload : CommandBase<FileDownloadCommand, ZeroOutput>
    {
        public FileDownload(
            ICommandParser<FileDownloadCommand> parser,
            ICommandValidator<FileDownloadCommand> validator,
            ICommandExecutor<FileDownloadCommand, ZeroOutput> executor,
            IResponseHandler<ZeroOutput> responseHandler) : base(parser, validator, executor, responseHandler)
        {

        }
    }
}