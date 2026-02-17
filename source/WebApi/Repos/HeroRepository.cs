using DataAccess;
using Domain;
using MongoDB.Driver;

namespace WebApi.Repos;

public class HeroRepository(IMongoDbConnectionFactory dbFactory) : IHeroRepository
{
    private IMongoCollection<Hero> Collection => dbFactory.GetDatabase().GetCollection<Hero>("Heroes");

    public async Task<Hero?> GetHero(Guid id, CancellationToken ct = default)
    {
        var filter = Builders<Hero>.Filter.Eq(hero => hero.Id, id);
        FindOptions<Hero>? opts = null;

        var cursor = await Collection.FindAsync(filter, opts, ct);

        return await cursor.SingleOrDefaultAsync(ct);
    }

    public async Task<IEnumerable<Hero>> GetHeroes(CancellationToken ct = default)
    {
        var filter = Builders<Hero>.Filter.Empty;
        FindOptions<Hero>? opts = null;

        var cursor = await Collection.FindAsync(filter, opts, ct);

        return await cursor.ToListAsync(ct);
    }

    public async Task<Guid> CreateHero(Hero hero, CancellationToken ct = default)
    {
        InsertOneOptions? opts = null;

        await Collection.InsertOneAsync(hero, opts, ct);

        return hero.Id;
    }

    public async Task<bool> UpdateHero(Hero hero, CancellationToken ct = default)
    {
        var filter = Builders<Hero>.Filter.Eq(h => h.Id, hero.Id);
        var opts = new ReplaceOptions { IsUpsert = true }; // If the hero doesn't exist, it will be created.

        var result = await Collection.ReplaceOneAsync(filter, hero, opts, ct);

        return result.IsAcknowledged && result.IsModifiedCountAvailable && result.ModifiedCount > 0;
    }

    public async Task<bool> DeleteHero(Guid id, CancellationToken ct = default)
    {
        var filter = Builders<Hero>.Filter.Eq(h => h.Id, id);
        DeleteOptions? opts = null;

        var result = await Collection.DeleteManyAsync(filter, opts, ct);

        return result.IsAcknowledged && result.DeletedCount > 0;
    }

}
