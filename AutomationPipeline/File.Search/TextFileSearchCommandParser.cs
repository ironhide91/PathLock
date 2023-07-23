using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Search
{
    internal class TextFileSearchCommandParser : ICommandParser<TextFileSearchCommand>
    {
        public static readonly TextFileSearchCommandParser Instance = new TextFileSearchCommandParser();

        private TextFileSearchCommandParser()
        {

        }

        public bool TryParse(string stringCommand, out TextFileSearchCommand command)
        {
            command = null;

            if (string.IsNullOrEmpty(stringCommand))
                return false;

            var arguments = stringCommand.Split(' ');

            if (arguments.Length != 3)
                return false;

            if (string.IsNullOrEmpty(arguments[1]))
                return false;

            if (string.IsNullOrEmpty(arguments[2]))
                return false;

            command = new TextFileSearchCommand(sourceFile: arguments[1], searchTerm: arguments[2]);

            return true;
        }
    }
}