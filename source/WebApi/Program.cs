using DataAccess;
using Domain;
using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using WebApi.Repos;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Dependency Injection
builder.Services.AddSingleton<IMongoDbConnectionFactory, MongoDbConnectionFactory>();
builder.Services.AddScoped<IHeroRepository, HeroRepository>();

// Configure JSON options to be more flexible and consistent with common API practices
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.AllowTrailingCommas = true;
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

const string AllowUiOrigins = "AllowUiOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowUiOrigins, policy =>
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors(AllowUiOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.MapGet("/hero", async ([FromServices]IHeroRepository repo, CancellationToken ct) =>
{
    var result = await repo.GetHeroes(ct);
    return Results.Ok(result);
})
.WithName("GetHeroes");

app.MapGet("/hero/{id}", async ([FromRoute]int id, [FromServices]IHeroRepository repo, CancellationToken ct) =>
{
    return await repo.GetHero(id, ct) is Hero hero
        ? Results.Ok(hero)
        : Results.NotFound();
}).WithName("GetHero");


app.MapPost("/hero", async ([FromBody]Hero hero, [FromServices]IHeroRepository repo, CancellationToken ct) =>
{
    int heroId = await repo.CreateHero(hero, ct);
    return Results.Created($"/hero/{heroId}", hero);
}).AddEndpointFilter<RequestValidationFilter>().WithName("CreateHero");


app.MapPut("/hero/{id}", async ([FromRoute]int id, [FromBody] Hero hero, [FromServices]IHeroRepository repo, CancellationToken ct) =>
{
    if (id != hero.Id) return Results.BadRequest("ID mismatch.");
    bool updated = await repo.UpdateHero(hero, ct);
    return Results.Ok(new { id, updated });
}).AddEndpointFilter<RequestValidationFilter>().WithName("UpdateHero");


app.MapDelete("/hero/{id}", async ([FromRoute]int id, [FromServices]IHeroRepository repo, CancellationToken ct) =>
{
    bool deleted = await repo.DeleteHero(id, ct);
    return Results.Ok(new { id, deleted });
}).WithName("DeleteHero");


app.Run();
