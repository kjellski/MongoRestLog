
using System.Collections.Generic;
using MongoRestLog.Model;

namespace MongoRestLog.ViewModel
{
    public class LogEntryList
    {
        public LogEntryList(List<LogEntry> list)
        {
            LogEntries = list;
        }

        public List<LogEntry> LogEntries { get; set; }
    }
}
