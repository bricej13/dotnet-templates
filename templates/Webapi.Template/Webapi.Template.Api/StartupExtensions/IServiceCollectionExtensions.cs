using Webapi.Template.DB;

namespace Webapi.Template.Api.StartupExtensions;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection SetupServices(this IServiceCollection services,
        ConfigurationManager config)
    {

        return services;
    }
    public static IServiceCollection SetupSwagger(this IServiceCollection services,
        ConfigurationManager config)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
    
    public static IServiceCollection SetupDatabase(this IServiceCollection services,
        ConfigurationManager config)
    {
        var connectionString = config.GetConnectionString("Database");
        services.AddSqlite<DataContext>(connectionString); // TODO: Replace with correct db provider.

        return services;
    }

}