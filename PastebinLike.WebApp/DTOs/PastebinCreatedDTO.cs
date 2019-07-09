using PastebinLike.Core.Entities;
using System;

namespace PastebinLike.WebApp.DTOs
{
    public class PastebinCreatedDTO
    {
        private PastebinCreatedDTO(Pastebin pastebin)
        {
            Id = pastebin.Id;
            GeneratedUrl = $"/pastebin/{pastebin.Id}";
        }

        public string Id { get; set; }
        public string GeneratedUrl { get; set; }

        public static PastebinCreatedDTO CreateFromPastebin(Pastebin pastebin)
        {
            return new PastebinCreatedDTO(pastebin);
        }
    }
}
