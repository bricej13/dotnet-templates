# An opinionated n-tier WebApi

## Configuration

## Entity Framework Core
### Additional config required
- Update database provider (sqlite is setup by default)
- Remove sqlite nuget package
- Update `IServiceCollectionExtensions.cs` to use correct database provider
- Update database connection string in `appsettings.json` & `appsettings.Development.json`

### Adding migrations
run `dotnet ef migraions add init` from the DB project
rut `dotnet ef database update` to apply migrations

## Dependency Injection
Servies are added in the `SetupServices` method if `IServiceColelctionExtensions.cs`


## Serilog
## Automapper
Automapper is seutp using the `SetupAutomapper` extension method and `AutomapperProfile` class.
Example configurations should be removed

## SPA UI
## Swagger MSBuild
