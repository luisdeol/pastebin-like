using System;

namespace PastebinLike.Core.Entities
{
    public class Pastebin
    {
        public Guid Id { get; set; }
        public string ObjectKey { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
