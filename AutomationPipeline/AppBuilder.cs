using PathLock.AutomationPipeline.Core;
using PathLock.AutomationPipeline.File.Copy;
using PathLock.AutomationPipeline.File.Delete;
using PathLock.AutomationPipeline.File.Download;
using PathLock.AutomationPipeline.File.Search;
using PathLock.AutomationPipeline.Folder.Create;
using PathLock.AutomationPipeline.Folder.Query;
using PathLock.AutomationPipeline.Wait;

namespace PathLock.AutomationPipeline
{
    public class AppBuilder
    {
        public AppBuilder()
        {
            processors = new Dictionary<string, ICommandRunner>();
            knownCommands = new HashSet<string>();
        }

        public void AddDefaultCommands()
        {
            var fileCopy = new FileCopy(
                FileCopyCommandParser.Instance,
                FileCopyCommandValidator.Instance,
                FileCopyCommandExecutor.Instance,
                FileCopyResponseHandler.Instance);
            With(FileCopyCommand.key, fileCopy);

            var fileDelete = new FileDelete(
                FileDeleteCommandParser.Instance,
                FileDeleteCommandValidator.Instance,
                FileDeleteCommandExecutor.Instance,
                FileDeleteResponseHandler.Instance);
            With(FileDeleteCommand.key, fileDelete);

            var fileDownload = new FileDownload(
                FileDownloadCommandParser.Instance,
                FileDownloadCommandValidator.Instance,
                FileDownloadCommandExecutor.Instance,
                FileDownloadResponseHandler.Instance);
            With(FileDownloadCommand.key, fileDownload);

            var fileSearch = new TextFileSearch(
                TextFileSearchCommandParser.Instance,
                TextFileSearchCommandValidator.Instance,
                TextFileSearchCommandExecutor.Instance,
                TextFileSearchResponseHandler.Instance);
            With(TextFileSearchCommand.key, fileSearch);

            var folderCreate = new FolderCreate(
                FolderCreateCommandParser.Instance,
                FolderCreateCommandValidator.Instance,
                FolderCreateCommandExecutor.Instance,
                FolderCreateResponseHandler.Instance);
            With(FolderCreateCommand.key, folderCreate);

            var folderQuery = new FolderQuery(
                FolderQueryCommandParser.Instance,
                FolderQueryCommandValidator.Instance,
                FolderQueryCommandExecutor.Instance,
                FolderQueryResponseHandler.Instance);
            With(FolderQueryCommand.key, folderQuery);

            var wait = new WaitImpl(
                WaitCommandParser.Instance,
                WaitCommandValidator.Instance,
                WaitCommandExecutor.Instance,
                WaitResponseHandler.Instance);
            With(WaitCommand.key, wait);
        }

        public AppBuilder With(string key, ICommandRunner commandProcess)
        {
            processors.Add(key, commandProcess);
            knownCommands.Add(key);
            return this;
        }

        public App Build()
        {
            var commandIdentifier = new CommandIdentifier(knownCommands);
            var app = new App(processors, commandIdentifier);
            return app;
        }

        private readonly Dictionary<string, ICommandRunner> processors;
        private readonly HashSet<string> knownCommands;
    }
}