namespace PathLock.AutomationPipeline.Core
{
    public interface IResponseHandler<TResponse> where TResponse : IResponse
    {
        void Handle(TResponse response);
    }
}