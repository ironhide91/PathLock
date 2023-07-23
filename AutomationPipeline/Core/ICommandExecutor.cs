namespace PathLock.AutomationPipeline.Core
{
    public interface ICommandExecutor<TCommand, TResponse>
        where TCommand : ICommand<TCommand>
        where TResponse : IResponse
    {
        TResponse Execute(TCommand command);
    }
}