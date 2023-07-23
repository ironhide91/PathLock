namespace PathLock.AutomationPipeline.Core
{
    public interface ICommandParser<T> where T : ICommand<T>
    {
        bool TryParse(string stringCommand, out T commnad);
    }
}