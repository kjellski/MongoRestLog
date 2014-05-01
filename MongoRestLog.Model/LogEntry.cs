using System;
using System.Collections.Generic;

namespace MongoRestLog.Model
{
    public class LogEntry
    {
        public String Content { get; set; }
        public ELogType Type { get; set; }
    }

    public class Query<T>
    {
        private Func<IEnumerable<T>> query;

        public Query(Func<IEnumerable<T>> query)
        {
            this.query = query;
        }
    }
}