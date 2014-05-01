using System.Reflection;
using Autofac;
using MongoRestLog.Services.Database;
using Module = Autofac.Module;

namespace MongoRestLog.Services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof (ServicesModule)))
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();
            builder.RegisterType<MongoRestLogDatabase>().As<IMongoRestLogDatabase>();
        }
    }
}