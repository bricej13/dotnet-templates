using Serilog;
using Webapi.Template.Core.Services;
using Webapi.Template.DB;

namespace Webapi.Template.Web.Api.StartupExtensions;

public static class ConfigureHostBuilderExtensions
{
    public static ConfigureHostBuilder SetupLogging(this ConfigureHostBuilder host,
        ConfigurationManager config)
    {
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(config)
            .CreateLogger();

        host.UseSerilog();
        
        return host;
    }


}