using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace ScrumBoard.Common.WebBuilderOptions
{
    public static class ConfigurationFiles
    {
        public static WebApplicationBuilder AddCommonConfiguration(this WebApplicationBuilder builder)
        {
            builder.Configuration.AddJsonFile("appsettings.local.json", true, true);
            return builder;
        }
    }
}
