using Domain;
using Microsoft.AspNetCore.Mvc;
using ModelContextProtocol.Server;
using System.ComponentModel;
using WebApi.Repos;

namespace WebApi.Endpoints;

[McpServerToolType]
internal static class McpHandlers
{
    [McpServerTool(Name = "GetHeroes", Title = "Get all heroes", Destructive = false, Idempotent = true, ReadOnly = true)]
    [Description("Gets every hero without any filter criteria.")]
    internal static async Task<IEnumerable<Hero>> GetHeroes([FromServices] IMcpHeroRepository repo, CancellationToken ct)
    {
        return await repo.GetHeroes(ct);
    }

    [McpServerTool(Name = "GetHeroesByNamePattern", Title = "Get heroes by name pattern", Destructive = false, Idempotent = true, ReadOnly = true)]
    [Description("Gets only those heroes whose name matches the specified regular expression pattern, case insensitive.")]
    internal static async Task<IEnumerable<Hero>> GetHeroesByNamePattern(string pattern, [FromServices] IMcpHeroRepository repo, CancellationToken ct)
    {
        return await repo.GetHeroesByNamePattern(pattern, ct);
    }

    [McpServerTool(Name = "CreateNewHero", Title = "Create a new hero", Destructive = false, Idempotent = false, ReadOnly = false)]
    [Description("Creates a new hero with the specified name, and a randomly generated id as GUIDv7. Returns the id of the newly created hero.")]
    internal static async Task<Guid> CreateNewHero(string name, [FromServices] IMcpHeroRepository repo, CancellationToken ct)
    {
        Hero hero = new() { Id = Guid.CreateVersion7(), Name = name };
        return await repo.CreateHero(hero, ct);
    }

    [McpServerTool(Name = "UpsertHero", Title = "Updates an existing hero or creates a new one", Destructive = false, Idempotent = true, ReadOnly = false)]
    [Description("Updates the name of an existing hero based on the specified id, or creates it if it doesn't exist. Returns true for updates, and false for upserts.")]
    internal static async Task<bool> UpsertHero(Guid id, string name, [FromServices] IMcpHeroRepository repo, CancellationToken ct)
    {
        Hero hero = new() { Id = id, Name = name };
        return await repo.UpdateHero(hero, ct);
    }

    [McpServerTool(Name = "DeleteHero", Title = "Deletes an existing hero", Destructive = true, Idempotent = false, ReadOnly = false)]
    [Description("Deletes an existing hero based on the specified id. Returns true if the hero was successfully deleted, or false if no hero with the specified id exists anymore.")]
    internal static async Task<bool> DeleteHero(Guid id, [FromServices] IMcpHeroRepository repo, CancellationToken ct)
    {
        return await repo.DeleteHero(id, ct);
    }

}
