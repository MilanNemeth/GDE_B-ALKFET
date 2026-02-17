using Domain;

namespace WebApi.Repos;

public interface IHeroRepository
{
    Task<Hero?> GetHero(int id, CancellationToken ct = default);
    Task<IEnumerable<Hero>> GetHeroes(CancellationToken ct = default);
    Task<int> CreateHero(Hero hero, CancellationToken ct = default);
    Task<bool> UpdateHero(Hero hero, CancellationToken ct = default);
    Task<bool> DeleteHero(int id, CancellationToken ct = default);
}
