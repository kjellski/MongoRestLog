
using Autofac;
using MongoRestLog.Services;
using Nancy.Bootstrappers.Autofac;

namespace MongoRestLog
{
    using Nancy;

    public class Bootstrapper : AutofacNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

        //protected override void ApplicationStartup(ILifetimeScope container, IPipelines pipelines)
        //{
        //    // No registrations should be performed in here, however you may
        //    // resolve things that are needed during application startup.
        //}

        //protected override void ConfigureApplicationContainer(ILifetimeScope existingContainer)
        //{
        //    // Perform registration that should have an application lifetime
        //}

        protected override void ConfigureRequestContainer(ILifetimeScope container, NancyContext context)
        {
            // Perform registrations that should have a request lifetime
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ServicesModule());
            builder.Update(container.ComponentRegistry);
        }

        //protected override void RequestStartup(ILifetimeScope container, IPipelines pipelines, NancyContext context)
        //{
        //    // No registrations should be performed in here, however you may
        //    // resolve things that are needed during request startup.
        //}
    }
}