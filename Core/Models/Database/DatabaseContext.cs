using Microsoft.EntityFrameworkCore;

namespace Core.Models.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<User> Users{ get; set; }
    }
}
