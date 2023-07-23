namespace PathLock.AutomationPipeline.Core
{
    public class ZeroOutput : IResponse
    {
        public static readonly ZeroOutput Instance = new ZeroOutput();

        private ZeroOutput()
        {
            
        }
    }
}