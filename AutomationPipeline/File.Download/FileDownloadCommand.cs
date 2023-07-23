using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.File.Download
{
    internal class FileDownloadCommand : ICommand<FileDownloadCommand>
    {
        internal FileDownloadCommand(string url, string path)
        {
            Url = url;
            Path = path;
        }

        public readonly string Url;

        public readonly string Path;

        public string Key { get { return key; } }

        public FileDownloadCommand Argument => this;

        public static readonly string key = "File.Download";
    }
}