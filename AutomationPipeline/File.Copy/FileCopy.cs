using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Copy
{
    internal class FileCopy : CommandBase<FileCopyCommand, ZeroOutput>
    {
        public FileCopy(
            ICommandParser<FileCopyCommand> parser,
            ICommandValidator<FileCopyCommand> validator,
            ICommandExecutor<FileCopyCommand, ZeroOutput> executor,
            IResponseHandler<ZeroOutput> responseHandler) : base(parser, validator, executor, responseHandler)
        {

        }
    }
}