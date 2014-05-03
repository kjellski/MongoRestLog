using System;
using MongoRestLog.Services;
using Nancy;
using Nancy.ModelBinding;

namespace MongoRestLog.Modules
{
    public class ResourceModule<TResourceModel> : NancyModule
    {
        private readonly IMongoRestLogDatabase _db;
        private readonly ResourcePaths _paths;

        protected ResourceModule(IMongoRestLogDatabase db, String path)
            : this(db, new ResourcePaths(path))
        {   
        }

        protected ResourceModule(IMongoRestLogDatabase db, ResourcePaths paths)
            : base(paths.Path)
        {
            _db = db;
            this.Bind<TResourceModel>();

            // routes
            _paths = paths;
            Get[paths.List] = parameters => List(parameters);
            Post[paths.Create] = parameters => Create(parameters);

            Get[paths.Show] = parameters => Show(parameters);
            Put[paths.Update] = parameters => Update(parameters);
            Delete[paths.Destroy] = parameters => Destroy(parameters);
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
