﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using MongoRestLog.Services.Properties;

namespace MongoRestLog.Services.Database
{
    public class MongoRestLogDatabase : IMongoRestLogDatabase
    {
        private readonly MongoDatabase _db;

        public MongoRestLogDatabase()
        {
            JsonWriterSettings.Defaults.Indent = true;

            var client = new MongoClient(Settings.Default.MongoRestLogConnectionString);
            var server = client.GetServer();
            _db = server.GetDatabase(Settings.Default.MongoRestLogDatabaseName);
        }

        public MongoCollection<TCollectionModel> GetCollection<TCollectionModel>()
        {
            return _db.GetCollection<TCollectionModel>(ReflectCollectionName<TCollectionModel>());
        }

        private static string ReflectCollectionName<TCollectionModel>()
        {
            var collectionName = typeof (TCollectionModel).Name.ToLower();
            return collectionName;
        }

        public bool Save<TCollectionModel>(TCollectionModel instanceToBeSaved)
        {
            var result = _db.GetCollection<TCollectionModel>(ReflectCollectionName<TCollectionModel>()).Save(instanceToBeSaved);
            return result.Ok;
        }

        public String GetServerStats()
        {
            var dbStats = _db.GetStats();
            var stats = new BsonDocument
            {
                {"collection_count", dbStats.CollectionCount},
                {"file_size", (int) dbStats.FileSize},
                {"object_count", (int) dbStats.ObjectCount},
            };
            return stats.ToString();
        }
    }
}