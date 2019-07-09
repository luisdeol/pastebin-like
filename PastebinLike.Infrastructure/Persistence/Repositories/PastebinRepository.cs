using PastebinLike.Core.Entities;
using PastebinLike.Core.Repositories;
using System.Linq;

namespace PastebinLike.Infrastructure.Persistence.Repositories
{
    public class PastebinRepository : IPastebinRepository
    {
        private readonly PastebinLikeContext _context;

        public PastebinRepository(PastebinLikeContext context)
        {
            _context = context;
        }

        public Pastebin AddPastebin(Pastebin pastebin)
        {
            _context.Pastebins.Add(pastebin);
            _context.SaveChanges();

            return pastebin;
        }

        public Pastebin GetPastebin(string id)
        {
            var pastebin = _context.Pastebins.SingleOrDefault(p => p.Id == id);

            return pastebin;
        }
    }
}
