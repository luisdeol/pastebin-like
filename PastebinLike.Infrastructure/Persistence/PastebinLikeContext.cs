using Microsoft.EntityFrameworkCore;
using PastebinLike.Core.Entities;

namespace PastebinLike.Infrastructure.Persistence
{
    public class PastebinLikeContext : DbContext
    {
        public PastebinLikeContext(DbContextOptions<PastebinLikeContext> options) : base(options)
        {
            
        }

        public DbSet<Pastebin> Pastebin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pastebin>().ToTable("tb_Pastebin");
        }
    }
}
