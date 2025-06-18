using Avalon.Domain;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace Avalon.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDb") ?? "mongodb://localhost:27017");
            _database = client.GetDatabase("avalon");
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("users");
        public IMongoCollection<Product> Products => _database.GetCollection<Product>("products");
        public IMongoCollection<AuditLog> AuditLogs => _database.GetCollection<AuditLog>("auditLogs");
    }
}
