using System;
using System.Threading.Tasks;
using PastebinLike.Infrastructure.Accessors;
using PastebinLike.WebApp.DTOs;

namespace PastebinLike.WebApp.Services
{
    public class PastebinService : IPastebinService
    {
        private readonly FileStorageService _storageService;

        public PastebinService(FileStorageService storageService)
        {
            _storageService = storageService;
        }
        public async Task<PastebinCreatedDTO> CreatePastebin(PastebinToCreateDTO pastebin)
        {
            await _storageService.SavePastebinToStorage(pastebin.ObjectKey, pastebin.Content);

            throw new NotImplementedException();
        }

        public PastebinToBeViewedDTO GetPastebin(string id)
        {
            throw new NotImplementedException();
        }
    }
}
