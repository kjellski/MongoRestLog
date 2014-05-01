namespace MongoRestLog.Model
{
    public struct ELogType
    {
        public static readonly int All = 0;
        public static readonly int Debug = 10;
        public static readonly int Info = 100;
        public static readonly int Warning = 1000;
        public static readonly int Error = 10000;
        public static readonly int Fatal = 100000;

        private int InternalValue { get; set; }

        public override bool Equals(object obj)
        {
            ELogType otherObj = (ELogType)obj;
            return otherObj.InternalValue.Equals(this.InternalValue);
        }

        public static bool operator >(ELogType left, ELogType right)
        {
            return (left.InternalValue > right.InternalValue);
        }

        public static bool operator <(ELogType left, ELogType right)
        {
            return (left.InternalValue < right.InternalValue);
        }

        public static implicit operator ELogType(int otherType)
        {
            return new ELogType
            {
                InternalValue = otherType
            };
        }
    }
}