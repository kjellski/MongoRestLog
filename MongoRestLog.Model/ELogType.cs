namespace MongoRestLog.Model
{
    public enum ELogType
    {
        All     = 0,
        Debug   = 10,
        Info    = 100,
        Warning = 1000,
        Error   = 10000,
        Fatal   = 100000
    }
}