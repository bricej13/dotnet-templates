using Webapi.Template.Web.Api.StartupExtensions;

var builder = WebApplication.CreateBuilder(args);


builder.Host.SetupLogging(builder.Configuration);
builder.Services.AddControllers();
builder.Services.SetupAutomapper(builder.Configuration);
builder.Services.SetupServices(builder.Configuration);
builder.Services.SetupSwagger(builder.Configuration);
builder.Services.SetupDatabase(builder.Configuration);

var app = builder.Build();




if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();