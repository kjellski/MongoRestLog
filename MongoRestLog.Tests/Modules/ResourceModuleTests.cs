using Nancy;
using Nancy.Testing;
using NUnit.Framework;

namespace MongoRestLog.Tests.Modules
{
    [TestFixture]
    public class ResourceModuleTests
    {
        private readonly DefaultNancyBootstrapper _bootstrapper = new DefaultNancyBootstrapper();
        private Browser _browser;

        [SetUp]
        public void SetUp()
        {
            _browser = new Browser(_bootstrapper);
        }

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
}