using Avalon.Domain;
using Microsoft.EntityFrameworkCore;

namespace Avalon.Data
{
    public class AvalonDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public AvalonDbContext(DbContextOptions<AvalonDbContext> options)
            : base(options)
        {
        }
    }
}
