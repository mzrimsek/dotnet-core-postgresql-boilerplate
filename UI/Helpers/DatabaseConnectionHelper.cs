using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Integration.EntityFramework.Models;

namespace UI.Helpers
{
    public static class DatabaseConnectionHelper
    {
        public static void AddDatabaseConnectionToServices(IServiceCollection services, IConfigurationRoot Configuration)
        {
            var connectionString = Configuration["DbContextSettings:ConnectionString"];
            services.AddDbContext<DatabaseContext>(opts => opts.UseNpgsql(connectionString));
        }
    }
}