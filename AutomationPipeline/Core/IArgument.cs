namespace PathLock.AutomationPipeline.Core
{
    internal interface IArgument<T>
    {
        T Value { get; }
    }
}