using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Integration.EntityFramework.Models;

namespace UI.Helpers
{
    public static class StartupHelper
    {
        public static void AddDatabaseConnectionToServices(IServiceCollection services, IConfigurationRoot Configuration)
        {
            var connectionString = Configuration["DbContextSettings:ConnectionString"];
            services.AddDbContext<DatabaseContext>(opts => opts.UseNpgsql(connectionString));
        }

        public static IConfigurationBuilder GetConfigurationBuilder(IHostingEnvironment env)
        {
            return new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
        }
    }
}