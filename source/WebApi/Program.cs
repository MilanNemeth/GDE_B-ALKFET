using WebApi.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppServices();

// Dependency Injection
builder.Services.AddDomainServices();

WebApplication app = builder.Build();

app.ConfigureApp();
   
app.MapEndpoints(app.Environment);

await app.RunAsync();
