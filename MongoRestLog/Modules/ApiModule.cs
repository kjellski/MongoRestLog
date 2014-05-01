using System;
using System.Dynamic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoRestLog.Model;
using MongoRestLog.Services;
using MongoRestLog.ViewModel;
using Nancy;
using Nancy.ModelBinding;

namespace MongoRestLog.Modules
{
    public class ApiModule : NancyModule
    {
        private readonly IMongoRestLogDatabase _db;
        public const String Path = "/api";

        public ApiModule(IMongoRestLogDatabase db)
            : base(Path)
        {
            _db = db;

            Get[]

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
    public class ResourceModule<TResourceModel> : NancyModule

    {
        private readonly IMongoRestLogDatabase _db;

        ResourceModule(IMongoRestLogDatabase db, String path)
            : base(path)
        {
            _db = db;
            this.Bind<TResourceModel>();

            Get["/"] = parameters => List(parameters);
            Post["/"] = parameters => Create(parameters);

            Get["/{id}"] = parameters => Show(parameters);
            Put["/{id}"] = parameters => Update(parameters);
            Delete["/{id}"] = parameters => Destroy(parameters);
        }

        private object Destroy(object parameters)
        {
            throw new NotImplementedException();
        }

        private object Update(object parameters)
        {
            throw new NotImplementedException();
        }

        private object Show(object parameters)
        {
            throw new NotImplementedException();
        }

        private object Create(object parameters)
        {
            throw new NotImplementedException();
        }

        private object List(object parameters)
        {
            throw new NotImplementedException();
        }
    }
}