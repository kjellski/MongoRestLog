using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoRestLog.Model;
using MongoRestLog.Services;
using Nancy;

namespace MongoRestLog.Modules
{
    public class ApiModule : NancyModule
    {
        private readonly IMongoRestLogDatabase _db;

        public ApiModule(IMongoRestLogDatabase db)
        {
            _db = db;

            Get["/api"] = parameters =>
            {
                var logs = _db.GetCollection<LogEntry>();
                var result = logs.FindAll().ToList();
                return result.ToJson();
            };

            Get["/api/{id}"] = parameters =>
            {
                var logs = _db.GetCollection<LogEntry>();
                return logs.FindOneById(parameters.id).ToJson();
            };
        }
    }
}