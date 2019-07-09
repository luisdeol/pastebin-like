using PastebinLike.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastebinLike.WebApp.DTOs
{
    public class PastebinToBeViewedDTO
    {
        public string Content { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public DateTime CreationDate { get; private set; }
        private PastebinToBeViewedDTO(Pastebin pastebin, string content)
        {
            Content = content;
            ExpirationDate = pastebin.ExpirationDate;
            CreationDate = pastebin.CreationDate;
        }

        public static PastebinToBeViewedDTO FromPastebinAndContent(Pastebin pastebin, string content)
        {
            return new PastebinToBeViewedDTO(pastebin, content);
        }
    }
}
