namespace PathLock.AutomationPipeline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appBuilder = new AppBuilder();
            appBuilder.AddDefaultCommands();

            var app = appBuilder.Build();
            app.Run();
        }
    }
}