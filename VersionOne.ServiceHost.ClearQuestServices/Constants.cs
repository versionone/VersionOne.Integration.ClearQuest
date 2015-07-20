namespace VersionOne.ServiceHost.ClearQuestServices {
    public enum ComparisonOperator {
        Equal = 1,
        NotEqual = 2,
        LessThan = 3,
        LessThanOrEqual = 4,
        GreaterThan = 5,
        GreaterThanOrEqual = 6,
        Like = 7,
        NotLike = 8,
        Between = 9,
        NotBetween = 10,
        IsNull = 11,
        IsNotNull = 12,
        In = 13,
        NotIn = 14,
    }
    
    internal static class Constants {
        // refer to clearquest.bas for more information

        // session type
        public const int SessionTypePrivate = 2;
    }
}
