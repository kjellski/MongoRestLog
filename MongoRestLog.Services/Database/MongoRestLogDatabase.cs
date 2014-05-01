using System;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;

namespace MongoRestLog.Services
{
    internal class MongoRestLogDatabase : IMongoRestLogDatabase
    {

        private readonly MongoDatabase _db;

        public MongoRestLogDatabase()
        {
            JsonWriterSettings.Defaults.Indent = true;

            var client = new MongoClient(Properties.Settings.Default.MongoRestLogConnectionString);
            var server = client.GetServer();
            _db = server.GetDatabase(Properties.Settings.Default.MongoRestLogDatabaseName);
        }

        public MongoCollection<TCollectionModel> GetCollection<TCollectionModel>()
        {
            var collectionName = typeof (TCollectionModel).Name;
            return _db.GetCollection<TCollectionModel>(collectionName);
        }

        public String GetServerStats()
        {
            var dbStats = _db.GetStats();
            var stats = new BsonDocument
            {
                { "collection_count", dbStats.CollectionCount },
                { "file_size", (int)dbStats.FileSize },
                { "object_count", (int)dbStats.ObjectCount },
            };
            return stats.ToString();
        }
    }
}
