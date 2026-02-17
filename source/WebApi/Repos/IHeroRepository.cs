using Domain;

namespace WebApi.Repos;

public interface IHeroRepository
{
    Task<Hero?> GetHero(Guid id, CancellationToken ct = default);
    Task<IEnumerable<Hero>> GetHeroes(CancellationToken ct = default);
    Task<Guid> CreateHero(Hero hero, CancellationToken ct = default);
    Task<bool> UpdateHero(Hero hero, CancellationToken ct = default);
    Task<bool> DeleteHero(Guid id, CancellationToken ct = default);
}
