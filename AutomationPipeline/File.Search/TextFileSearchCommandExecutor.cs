using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Search
{
    internal class TextFileSearchCommandExecutor : ICommandExecutor<TextFileSearchCommand, TextFileSearchResponse>
    {
        public static readonly TextFileSearchCommandExecutor Instance = new TextFileSearchCommandExecutor();

        private TextFileSearchCommandExecutor()
        {

        }

        public TextFileSearchResponse Execute(TextFileSearchCommand command)
        {
            int count = 0;

            using (var stream = new StreamReader(command.SourceFile))
            {
                string line;

                while ((line = stream.ReadLine()) != null)
                {
                    if (line.Contains(command.SearchTerm, StringComparison.OrdinalIgnoreCase))
                        count++;
                }
            }               

            return new TextFileSearchResponse(count);
        }
    }
}