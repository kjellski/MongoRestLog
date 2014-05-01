using System;
using MongoDB.Driver;

namespace MongoRestLog.Services
{
    public interface IMongoRestLogDatabase
    {
        MongoCollection<TCollectionModel> GetCollection<TCollectionModel>();
        String GetServerStats();
    }
}