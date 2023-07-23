namespace PathLock.AutomationPipeline.Core
{
    internal interface ICommandIdentifier
    {
        bool TryIdentify(ReadOnlySpan<char> command, out string identifiedCommand);
    }
}