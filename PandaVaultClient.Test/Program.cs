using PandaVaultClient;
using PandaVaultClient.Test;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddPandaVault(); // Adding PandaVaultConfigurationSource

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<RabbitMQSettings>(builder.Configuration.GetSection("RabbitMQSettings"));

builder.Services.AddControllers();
//builder.Services.RegisterPandaVault(); // Registering PandaVaultClient

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapPandaVaultApi(); // Mapping PandaVaultClient endpoints
app.MapControllers();
app.Run();