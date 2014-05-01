using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoRestLog.Model
{
    public class LogEntry
    {

        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }

        public String Content { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        public int Type { get; set; }
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