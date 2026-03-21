using FoodManager.Catalog.CrossCutting.Extentions;
using FoodManager.Internal.Shared.Extensions;

var builder = WebApplication.CreateBuilder(args);

var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
    .AddJsonFile($"appsettings.{enviroment}.json", optional: true, reloadOnChange: false)
    .AddEnvironmentVariables();

var applicationSettings = builder.Configuration.GetApplicationSettings(builder.Environment);

builder.Services
    .AddMemoryCache()
    .AddMongo(applicationSettings.MongoSettings)
    .AddRepositories()
    .AddApiAuthentication(applicationSettings.KeycloakSettings.Realm)
    .ConfigureLiteBus()
    .AddApiSpecification()
    .AddValidators()
    .AddControllers()
    .AddNewtonsoftJson();

builder.Services.AddEndpointsApiExplorer();
builder.Host.UseSerilog(enviroment!, applicationSettings.MltSettings.SeqUrl!);

var app = builder.Build();

app.MapOpenApi();
app.UseSpecification("Catalog");

app.UseRequestContextLogging()
   .UseHttpsRedirection()
   .UseAuthentication()
   .UseAuthorization();

app.MapControllers();

await app.RunAsync();