using System;
using MongoRestLog.Services;
using Nancy;
using Nancy.ModelBinding;

namespace MongoRestLog.Modules
{
    public class ResourcePaths
    {
        private readonly String _pathPrefix;

        private string _listPostFix = "";
        public String ListPostFix
        {
            get { return _listPostFix; }
            set { _listPostFix = value; }
        }

        private string _createPostFix = "";
        public String CreatePostFix
        {
            get { return _createPostFix; }
            set { _createPostFix = value; }
        }

        private string _showPostFix = "";
        public String ShowPostFix
        {
            get { return _showPostFix; }
            set { _showPostFix = value; }
        }

        private string _updatePostFix = "";
        public String UpdatePostFix
        {
            get { return _updatePostFix; }
            set { _updatePostFix = value; }
        }

        private string _destroyPostFix = "";
        public String DestroyPostFix
        {
            get { return _destroyPostFix; }
            set { _destroyPostFix = value; }
        }

        public ResourcePaths(String pathPrefix)
        {
            if (!pathPrefix.EndsWith("/"))
                pathPrefix += "/";

            _pathPrefix = pathPrefix;
        }

        public String Path
        {
            get { return _pathPrefix; }
        }

        public String List
        {
            get { return Path + ListPostFix; }
        }

        public String Create
        {
            get { return Path + CreatePostFix; }
        }
        public String Show
        {
            get { return Path + ShowPostFix; }
        }
        public String Update
        {
            get { return Path + UpdatePostFix; }
        }

        public String Destroy
        {
            get { return Path + DestroyPostFix; }
        }
    }
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
