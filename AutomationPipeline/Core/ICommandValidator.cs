namespace PathLock.AutomationPipeline.Core
{
    public interface ICommandValidator<T> where T : ICommand<T>
    {
        (bool, string) IsValid(T command);
    }
}