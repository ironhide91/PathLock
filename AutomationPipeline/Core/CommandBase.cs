namespace PathLock.AutomationPipeline.Core
{
    public abstract class CommandBase<TCommand, TResponse> : ICommandRunner
        where TCommand : ICommand<TCommand>
        where TResponse : IResponse
    {
        public CommandBase(
            ICommandParser<TCommand> parser,
            ICommandValidator<TCommand> validator,
            ICommandExecutor<TCommand, TResponse> executor,
            IResponseHandler<TResponse> responseHandler)
        {
            this.parser = parser;
            this.validator = validator;
            this.executor = executor;
            this.responseHandler = responseHandler;
        }

        public CommandResponse Run(string stringCommand)
        {
            if (!parser.TryParse(stringCommand, out TCommand commnad))
            {
                return CommandResponse.Failure("unable to parse command.");
            }

            var (isValid, error) = validator.IsValid(commnad);

            if (!isValid)
            {
                return CommandResponse.Failure("invalid command. " + error);
            }

            TResponse result;

            try
            {
                result = executor.Execute(commnad);
                responseHandler.Handle(result);
            }
            catch (Exception e)
            {
                return CommandResponse.Failure("error occured while executing command. " + e.Message);
            }

            return CommandResponse.Success(result);
        }

        private readonly ICommandParser<TCommand> parser;
        private readonly ICommandValidator<TCommand> validator;
        private readonly ICommandExecutor<TCommand, TResponse> executor;
        private readonly IResponseHandler<TResponse> responseHandler;
    }
}