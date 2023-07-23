using PathLock.AutomationPipeline.Core;
using System.Threading.Tasks;

namespace PathLock.AutomationPipeline.File.Download
{
    internal class FileDownloadCommandExecutor : ICommandExecutor<FileDownloadCommand, ZeroOutput>
    {
        public static readonly FileDownloadCommandExecutor Instance = new FileDownloadCommandExecutor();

        private FileDownloadCommandExecutor()
        {

        }

        public ZeroOutput Execute(FileDownloadCommand command)
        {
            using (var client = new HttpClient())
            {
                Task<Stream> task = null;
                FileStream newFile = null;

                try
                {
                    task = client.GetStreamAsync(command.Url);
                    task.Wait();

                    var uri = new Uri(command.Url);
                    var name = Path.GetFileName(uri.LocalPath);

                    newFile = System.IO.File.Create(Path.Combine(command.Path, name));

                    task.Result.CopyTo(newFile);
                }
                finally
                {                    
                    task?.Result?.Close();
                    newFile.Close();
                    task?.Dispose();
                }                
            }

            return ZeroOutput.Instance;
        }
    }
}