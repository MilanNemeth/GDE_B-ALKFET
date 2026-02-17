using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DataAccess;

public class MongoDbConnectionFactory(IConfiguration configuration) : IMongoDbConnectionFactory, IDisposable
{
    private bool disposedValue;

    public string ConnectionString => configuration["MongoDb:ConneX"] ?? throw new InvalidOperationException("MongoDB connection string is not configured.");

    public string DatabaseName => configuration["MongoDb:Database"] ?? throw new InvalidOperationException("MongoDB database is not set.");

    public IMongoDatabase? Database { get; private set; }
    public IMongoDatabase GetDatabase()
    {
        if (Database == null)
        {
            var client = new MongoClient(ConnectionString);
            Database = client.GetDatabase(DatabaseName);
        }
        return Database;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~MongoDbConnectionFactory()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
