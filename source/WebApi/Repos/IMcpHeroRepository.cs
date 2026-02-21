using System;
using Domain;

namespace WebApi.Repos;

public interface IMcpHeroRepository : IHeroRepository
{
    Task<IEnumerable<Hero>> GetHeroesByNamePattern(string pattern, CancellationToken ct = default);
}
