using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Search
{
    internal class FileSearch : CommandBase<TextFileSearchCommand, TextFileSearchResponse>
    {
        public FileSearch(
            ICommandParser<TextFileSearchCommand> parser,
            ICommandValidator<TextFileSearchCommand> validator,
            ICommandExecutor<TextFileSearchCommand, TextFileSearchResponse> executor,
            IResponseHandler<TextFileSearchResponse> responseHandler) : base(parser, validator, executor, responseHandler)
        {

        }
    }
}