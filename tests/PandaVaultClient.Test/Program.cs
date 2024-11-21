using PandaVaultClient;
using PandaVaultClient.Test;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddPandaVault(); // Adding PandaVaultConfigurationSource
builder.RegisterPandaVaultEndpoint(); // optional, if you want to use the endpoint for all configurations

builder.Services.AddEndpointsApiExplorer();

builder.Services.Configure<RabbitMQSettings>(builder.Configuration.GetSection("RabbitMQSettings")); //for test only

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();