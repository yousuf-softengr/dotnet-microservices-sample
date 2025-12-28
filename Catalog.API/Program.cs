using Catalog.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(
    builder.Configuration.GetConnectionString("DefaultConnection")!);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();
