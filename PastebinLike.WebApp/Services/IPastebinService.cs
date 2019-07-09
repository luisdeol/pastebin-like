using PastebinLike.WebApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastebinLike.WebApp.Services
{
    public interface IPastebinService
    {
        PastebinCreatedDTO CreatePastebin(PastebinToCreateDTO pastebin);
        PastebinToBeViewedDTO GetPastebin(string id);
    }
}
