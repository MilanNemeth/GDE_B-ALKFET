using System;
using MongoDB.Driver;

namespace DataAccess;

public interface IMongoDbConnectionFactory
{
    string ConnectionString { get; }
    string DatabaseName { get; }
    IMongoDatabase GetDatabase();
}
