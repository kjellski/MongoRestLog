using MongoRestLog.Services;

namespace MongoRestLog
{
    using Nancy;

    public class ApiModule : NancyModule
    {
        private readonly IMongoRestLogDatabase _db;

        public ApiModule(IMongoRestLogDatabase db)
        {
            _db = db;

            Get["/api"] = parameters =>
            {
                return _db.GetServerStats();
            };
        }
    }
}
