using PathLock.AutomationPipeline.Core;

namespace PathLock.AutomationPipeline.Folder.Query
{
    internal class FolderQueryResponse : Response<IReadOnlyList<string>>
    {
        public FolderQueryResponse(IReadOnlyList<string> value) : base(value)
        {

        }
    }
}