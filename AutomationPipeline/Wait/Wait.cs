using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Wait
{
    internal class WaitImpl : CommandBase<WaitCommand, ZeroOutput>
    {
        public WaitImpl(
            ICommandParser<WaitCommand> parser,
            ICommandValidator<WaitCommand> validator,
            ICommandExecutor<WaitCommand, ZeroOutput> executor,
            IResponseHandler<ZeroOutput> responseHandler) : base(parser, validator, executor, responseHandler)
        {

        }
    }
}