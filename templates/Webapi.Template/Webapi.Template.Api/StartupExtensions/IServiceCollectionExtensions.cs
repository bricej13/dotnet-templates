using Webapi.Template.Core.Services;
using Webapi.Template.DB;

namespace Webapi.Template.Api.StartupExtensions;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection SetupServices(this IServiceCollection services,
        ConfigurationManager config)
    {
        services.AddTransient<IAuthorService, AuthorService>(); // TODO: Replace
        services.AddTransient<IBlogService, BlogService>(); // TODO: Replace
        services.AddTransient<IPostService, PostService>(); // TODO: Replace

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
    public static IServiceCollection SetupAutomapper(this IServiceCollection services,
        ConfigurationManager config)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        return services;
    }


}