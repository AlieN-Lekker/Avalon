using Avalon.Models;
using Microsoft.EntityFrameworkCore;

namespace Avalon.Database
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
