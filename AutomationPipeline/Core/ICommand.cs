namespace PathLock.AutomationPipeline.Core
{
    public interface ICommand<T>
    {
        string Key { get; }

        T Argument { get; }
    }
}