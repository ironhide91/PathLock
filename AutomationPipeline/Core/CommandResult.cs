namespace PathLock.AutomationPipeline.Core
{
    public class CommandResponse
    {
        public static CommandResponse Failure(string error)
        {
            return new CommandResponse(true, error, null);
        }

        public static CommandResponse Success(IResponse result)
        {
            return new CommandResponse(false, string.Empty, result);
        }

        private CommandResponse(bool failed, string error, IResponse response)
        {
            Failed = failed;
            Error = error;
            Response = response;
        }

        public readonly bool Failed;
        public readonly string Error;
        public readonly IResponse Response;
    }
}