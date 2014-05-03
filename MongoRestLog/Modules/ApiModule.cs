using System;
using System.Dynamic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoRestLog.Model;
using MongoRestLog.Services;
using MongoRestLog.ViewModel;

namespace MongoRestLog.Modules
{
    public class ApiModule : ResourceModule<LogEntry>
    {
        private readonly IMongoRestLogDatabase _db;
        public const String Path = "/api";

        public ApiModule(IMongoRestLogDatabase db)
            : base(db,Path)
        {
            _db = db;
            
            Get["/"] = parameters =>
            {
                var logs = _db.GetCollection<LogEntry>();
                var result = logs.FindAll().ToList();
                return View["Index", new LogEntryList(result)];
            };

            Get["/api/{id}"] = parameters =>
            {
                var logs = _db.GetCollection<LogEntry>();
                return logs.FindOneById(parameters.id).ToJson();
            };
        }
    }
}