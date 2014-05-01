using System;
using System.Collections.Generic;
using MongoRestLog.Model;
using MongoRestLog.Services.Database;

namespace MongoRestLog.Services.Implementation
{
    public class LogEntryService : ILogEntryService
    {
        private readonly MongoRestLogDatabase _db;

        public LogEntryService()
        {
            _db = new MongoRestLogDatabase();
        }

        public void Save(LogEntry newLogEntry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LogEntry> Query(Query<LogEntry> logEntryQuery)
        {
            throw new NotImplementedException();
        }
    }
}