using System.Collections.Generic;
using MongoRestLog.Model;

namespace MongoRestLog.Services
{
    public interface ILogEntryService
    {
        void Save(LogEntry newLogEntry);
        IEnumerable<LogEntry> Query(Query<LogEntry> logEntryQuery);
    }
}