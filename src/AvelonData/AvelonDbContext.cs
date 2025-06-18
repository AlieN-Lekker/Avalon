using Avelon.Domain;
using Microsoft.EntityFrameworkCore;

namespace Avelon.Data
{
    public class AvelonDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public AvelonDbContext(DbContextOptions<AvelonDbContext> options)
            : base(options)
        {
        }
    }
}
