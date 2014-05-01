using System;
using MongoRestLog.Model;
using MongoRestLog.Services.Database;
using NUnit.Framework;

namespace MongoRestLog.Services.Tests.Database
{
    [TestFixture]
    public class MongoRestLogDatabaseTests
    {
        [Test]
        [Category("Integration")]
        public void SavesALogEntryInDatabase()
        {
            // arrange
            var doc = new LogEntry
            {
                Content =
                    Guid.NewGuid() +
                    @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Type = ELogType.Error
            };
            var db = new MongoRestLogDatabase();
            // act 
            var succeeded = db.Save(doc);

            // assert
            Assert.That(succeeded, Is.True);
        }
    }
}