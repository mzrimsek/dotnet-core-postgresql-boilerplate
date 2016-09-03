using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Core.Interfaces;
using Integration.EntityFramework.Models;
using Integration.EntityFramework.Repositories;
using UI.Getters;
using UI.Helpers;

namespace UI
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = ConfigurationBuilderGetter.GetConfigurationBuilder(env);
            Configuration = builder.Build();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            DatabaseConnectionHelper.AddDatabaseConnectionToServices(services, Configuration);

            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
