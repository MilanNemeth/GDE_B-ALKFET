using Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.MapGet("/hero", async (CancellationToken ct) =>
{
    return Results.Ok(Array.Empty<Hero>());
})
.WithName("GetHeroes");

app.MapGet("/hero/{id}", async (int id, CancellationToken ct) =>
{
    return Results.Ok(new { Id = id });
}).WithName("GetHero");


app.MapPost("/hero", async (Hero hero, CancellationToken ct) =>
{
    return Results.Ok(new { Id = 1 });
}).WithName("CreateHero");


app.MapPut("/hero/{id}", async (Hero hero, CancellationToken ct) =>
{
    return Results.Ok(new { hero.Id });
}).WithName("UpdateHero");


app.MapDelete("/hero/{id}", async (int id, CancellationToken ct) =>
{
    return Results.Ok();
}).WithName("DeleteHero");


app.Run();
