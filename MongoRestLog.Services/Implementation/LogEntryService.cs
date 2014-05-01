using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoRestLog.Model;

namespace MongoRestLog.Services
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
