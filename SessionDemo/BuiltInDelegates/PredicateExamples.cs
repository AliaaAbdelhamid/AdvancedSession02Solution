namespace SessionDemo.BuiltInDelegates
{
    internal class PredicateExamples
    {
        public static bool IsPositive(int n)
        {
            return n > 0;
        }

        public static bool IsNegative(int n)
        {
            return n < 0;
        }
        public static bool IsLong(string s)
        {
            return s.Length > 5;
        }
    }
}
