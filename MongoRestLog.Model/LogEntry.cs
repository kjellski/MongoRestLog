using System;

namespace MongoRestLog.Model
{
    public class LogEntry
    {
        public String Content { get; set; }
        public ELogType Type { get; set; }
    }
}
