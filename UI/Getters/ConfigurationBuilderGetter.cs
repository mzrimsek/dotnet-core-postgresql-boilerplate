using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UI.Getters
{
    public static class ConfigurationBuilderGetter
    {
        public static IConfigurationBuilder GetConfigurationBuilder(IHostingEnvironment env)
        {
            return new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
        }
    }
}