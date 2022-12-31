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
## Serilog
## Automapper
## SPA UI
## Swagger MSBuild
