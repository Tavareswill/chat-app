using DemoApp.Chat.Persistence.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.Chat.Persistence
{
    public class ChatDbContext : DbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> opts) : base(opts) { }
        public DbSet<MSGHIST> Interactions { get; set; }
    }
}
