using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline
{
    public class App
    {
        internal App(IReadOnlyDictionary<string, ICommandRunner> processors, ICommandIdentifier commandIdentifier)
        {
            this.processors = processors;
            this.commandIdentifier = commandIdentifier;
        }

        public void Run()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }

                if (input.Trim() == "exit")
                {
                    break;
                }

                string commandKey;

                if (!commandIdentifier.TryIdentify(input, out commandKey))
                {
                    Console.WriteLine("unknown command.");
                    continue;
                }

                _ = RunCommand(commandKey, input);
            }
        }

        public CommandResponse RunCommand(string commandKey, string command)
        {
            var response = processors[commandKey].Run(command);

            return response;
        }

        private readonly IReadOnlyDictionary<string, ICommandRunner> processors;
        private readonly ICommandIdentifier commandIdentifier;
    }
}