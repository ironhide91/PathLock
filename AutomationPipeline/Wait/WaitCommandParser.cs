using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Wait
{
    internal class WaitCommandParser : ICommandParser<WaitCommand>
    {
        public static readonly WaitCommandParser Instance = new WaitCommandParser();

        private WaitCommandParser()
        {

        }

        public bool TryParse(string stringCommand, out WaitCommand command)
        {
            command = null;

            if (string.IsNullOrEmpty(stringCommand))
                return false;

            var arguments = stringCommand.Split(' ');

            if (arguments.Length != 2)
                return false;

            if (string.IsNullOrEmpty(arguments[0]))
                return false;

            if (string.IsNullOrEmpty(arguments[1]))
                return false;

            if (!int.TryParse(arguments[1], out int seconds))
                return false;

            command = new WaitCommand(seconds);

            return true;
        }
    }
}