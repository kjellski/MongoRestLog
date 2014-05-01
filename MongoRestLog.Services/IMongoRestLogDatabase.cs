using System;
using MongoDB.Driver;

namespace MongoRestLog.Services
{
    public interface IMongoRestLogDatabase
    {
        bool Save<TCollectionModel>(TCollectionModel instanceToBeSaved);
        MongoCollection<TCollectionModel> GetCollection<TCollectionModel>();
        String GetServerStats();
    }
}