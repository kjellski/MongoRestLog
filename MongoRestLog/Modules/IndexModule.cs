using Nancy;

namespace MongoRestLog.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters => { return View["index"]; };
        }
    }
}