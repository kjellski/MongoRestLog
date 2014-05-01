using System;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using NUnit.Framework;

namespace MongoRestLog.Model.Tests
{
    [TestFixture]
    public class LogEntryTests
    {
        [SetUp]
        public void SetUp()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }

        [Test]
        public void TestMethod()
        {
            // arrange
            var logEntry = new LogEntry
            {
                Content = "TestContent!!!",
                Type = ELogType.Error
            };

            // act

            // assert
            Console.WriteLine(logEntry.ToJson());
        }
    }
}
