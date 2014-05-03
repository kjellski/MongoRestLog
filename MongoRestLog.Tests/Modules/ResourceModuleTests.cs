using System;
using MongoRestLog.Modules;
using Nancy;
using Nancy.Testing;
using NUnit.Framework;

namespace MongoRestLog.Tests.Modules
{
    [TestFixture]
    public class ResourceModuleTests
    {
        [SetUp]
        public void SetUp()
        {
            _browser = new Browser(with => with.Module<ResourceModule<Foo>>());
        }

        private readonly DefaultNancyBootstrapper _bootstrapper = new DefaultNancyBootstrapper();
        private Browser _browser;

        [Test]
        public void GetShouldReturnOk()
        {
            // arrange
            // act
            var result = _browser.Get("/", with => with.HttpRequest());

            // assert
            Assert.That(HttpStatusCode.OK, Is.EqualTo(result.StatusCode));
        }
    }

    public class Foo
    {
        public readonly Guid Guid = Guid.NewGuid();
    }
}