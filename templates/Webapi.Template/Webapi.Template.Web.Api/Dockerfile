FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Webapi.Template/Webapi.Template.csproj", "Webapi.Template/"]
RUN dotnet restore "Webapi.Template/Webapi.Template.csproj"
COPY . .
WORKDIR "/src/Webapi.Template"
RUN dotnet build "Webapi.Template.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Webapi.Template.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Webapi.Template.dll"]
