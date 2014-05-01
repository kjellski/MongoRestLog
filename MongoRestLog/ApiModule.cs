using System.Threading;
using MongoDB.Driver;

namespace MongoRestLog
{
    using Nancy;

    public class ApiModule : NancyModule
    {
        public ApiModule()
        {
            //var client = new MongoClient(Properties.Settings.Default.MongoRestLogConnectionString);
            //var server = client.GetServer();
            //var db = server.GetDatabase(Properties.Settings.Default.MongoRestLogDatabaseName);


            Get["/api"] = parameters =>
            {
                //db.GetStats();
                //return db.Server.BuildInfo;
                return "/api/";
            };
        }
    }
}
