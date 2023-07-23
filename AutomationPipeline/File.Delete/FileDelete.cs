using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Delete
{
    internal class FileDelete : CommandBase<FileDeleteCommand, ZeroOutput>
    {
        public FileDelete(
            ICommandParser<FileDeleteCommand> parser,
            ICommandValidator<FileDeleteCommand> validator,
            ICommandExecutor<FileDeleteCommand, ZeroOutput> executor,
            IResponseHandler<ZeroOutput> responseHandler) : base(parser, validator, executor, responseHandler)
        {

        }
    }
}