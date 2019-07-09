using System.Threading.Tasks;

namespace PastebinLike.Infrastructure.Accessors
{
    public class FileStorageService
    {
        public async Task<string> SavePastebinToStorage(string objectKey, string content)
        {
            return await Task.FromResult(objectKey);
        }
    }
}
