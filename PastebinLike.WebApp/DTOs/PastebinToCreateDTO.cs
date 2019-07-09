using PastebinLike.Core.Entities;
using System;

namespace PastebinLike.WebApp.DTOs
{
    public class PastebinToCreateDTO
    {
        public string Content { get; private set; }
        public DateTime ExpirationDate { get; set; }
        public string ObjectKey { get; set; }
        public string Title { get; set; }
    }
}
