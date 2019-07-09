using System;

namespace PastebinLike.Core.Entities
{
    public class Pastebin
    {
        public string Id { get; private set; }
        public string Title { get; private set; }
        public string ObjectKey { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public DateTime CreationDate { get; private set; }

        protected Pastebin()
        {

        }

        private Pastebin(string objectKey, string title, DateTime? expirationDate)
        {
            Id = Guid.NewGuid().ToString();
            ObjectKey = string.IsNullOrWhiteSpace(objectKey) ? Id : objectKey;
            Title = string.IsNullOrWhiteSpace(title) ? $"Pastebin created at {DateTime.Now:dd/MM/yyyy}" : title;
            ExpirationDate = expirationDate ?? DateTime.Now.AddDays(30);
            CreationDate = DateTime.Now;
        }

        public static Pastebin FromContentAndExpirationDate(string objectKey, string title, DateTime? expirationDate)
        {
            return new Pastebin(objectKey, title, expirationDate);
        }
    }
}
