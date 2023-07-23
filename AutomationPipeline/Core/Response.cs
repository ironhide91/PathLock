namespace PathLock.AutomationPipeline.Core
{
    public class Response<T> : IGenericRessponse<T>
    {
        public Response(T value)
        {
            this.Value = value;
        }

        public readonly T Value;
    }
}