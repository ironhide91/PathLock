using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Create
{
    internal class FolderCreate : CommandBase<FolderCreateCommand, ZeroOutput>
    {
        public FolderCreate(
            ICommandParser<FolderCreateCommand> parser,
            ICommandValidator<FolderCreateCommand> validator,
            ICommandExecutor<FolderCreateCommand, ZeroOutput> executor,
            IResponseHandler<ZeroOutput> responseHandler) : base(parser, validator, executor, responseHandler)
        {

        }
    }
}