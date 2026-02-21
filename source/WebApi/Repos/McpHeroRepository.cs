using DataAccess;
using Domain;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WebApi.Repos;

public class McpHeroRepository(IMongoDbConnectionFactory dbFactory) : HeroRepository(dbFactory), IMcpHeroRepository
{
    public async Task<IEnumerable<Hero>> GetHeroesByNamePattern(string pattern, CancellationToken ct = default)
    {
        var regex = new BsonRegularExpression(pattern, "i"); // "i" for case-insensitive matching
        var filter = Builders<Hero>.Filter.Regex(hero => hero.Name, regex);
        FindOptions<Hero>? opts = null;

        var cursor = await Collection.FindAsync(filter, opts, ct);

        return await cursor.ToListAsync(ct);
    }
}
