using PastebinLike.Core.Entities;

namespace PastebinLike.Core.Repositories
{
    public interface IPastebinRepository
    {
        Pastebin GetPastebin(string id);
        Pastebin AddPastebin(Pastebin pastebin);
    }
}
