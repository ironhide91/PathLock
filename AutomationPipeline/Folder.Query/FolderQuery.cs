using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Query
{
    internal class FolderQuery : CommandBase<FolderQueryCommand, FolderQueryResponse>
    {
        public FolderQuery(
            ICommandParser<FolderQueryCommand> parser,
            ICommandValidator<FolderQueryCommand> validator,
            ICommandExecutor<FolderQueryCommand, FolderQueryResponse> executor,
            IResponseHandler<FolderQueryResponse> responseHandler) : base(parser, validator, executor, responseHandler)
        {

        }
    }
}