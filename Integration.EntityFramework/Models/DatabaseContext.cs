using Microsoft.EntityFrameworkCore;

namespace Integration.EntityFramework.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<UserDatabaseModel> Users{ get; set; }
    }
}
