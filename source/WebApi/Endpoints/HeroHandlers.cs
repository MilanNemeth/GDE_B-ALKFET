using Domain;
using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using WebApi.Repos;

namespace WebApi.Endpoints;

internal static class HeroHandlers
{
    internal static RouteGroupBuilder MapHeroEndpoints(this RouteGroupBuilder routes)
    {
        routes.MapGet("", async ([FromServices] IHeroRepository repo, CancellationToken ct) =>
        {
            var result = await repo.GetHeroes(ct);
            return Results.Ok(result);
        })
        .WithName("GetHeroes");


        routes.MapGet("/{id}", async ([FromRoute] Guid id, [FromServices] IHeroRepository repo, CancellationToken ct) =>
        {
            return await repo.GetHero(id, ct) is Hero hero
                ? Results.Ok(hero)
                : Results.NotFound();
        }).WithName("GetHero");


        routes.MapPost("", async ([FromBody] Hero hero, [FromServices] IHeroRepository repo, CancellationToken ct) =>
        {
            Guid heroId = await repo.CreateHero(hero, ct);
            return Results.Created($"/{heroId}", hero);
        }).AddEndpointFilter<RequestValidationFilter>().WithName("CreateHero");


        routes.MapPut("/{id}", async ([FromRoute] Guid id, [FromBody] Hero hero, [FromServices] IHeroRepository repo, CancellationToken ct) =>
        {
            if (id != hero.Id) return Results.BadRequest("ID mismatch.");
            bool updated = await repo.UpdateHero(hero, ct);
            return Results.Ok(new { id, updated });
        }).AddEndpointFilter<RequestValidationFilter>().WithName("UpdateHero");


        routes.MapDelete("/{id}", async ([FromRoute] Guid id, [FromServices] IHeroRepository repo, CancellationToken ct) =>
        {
            bool deleted = await repo.DeleteHero(id, ct);
            return Results.Ok(new { id, deleted });
        }).WithName("DeleteHero");


        return routes;
    }
}
