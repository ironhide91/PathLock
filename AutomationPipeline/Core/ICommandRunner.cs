namespace PathLock.AutomationPipeline.Core
{
    public interface ICommandRunner
    {
        CommandResponse Run(string stringCommand);
    }
}