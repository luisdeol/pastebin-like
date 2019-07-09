using System.Threading.Tasks;

namespace PastebinLike.Infrastructure.Accessors
{
    public class FileStorageService
    {
        public Task<string> SavePastebinToStorage(string objectKey, string content)
        {
            return Task.FromResult(objectKey);
        }
    }
}
