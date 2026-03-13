namespace SessionDemo.DelegatesAsParameters
{
    public delegate bool FilterDelegate(int number);
    public delegate int TransformDelegate(int number);

    public class NumberProcessor
    {
        public static List<int> Filter(List<int> numbers, FilterDelegate filter)
        {
            List<int> result = new();
            foreach (int n in numbers)
            {
                if (filter(n))
                    result.Add(n);
            }
            return result;
        }

        public static List<int> Transform(List<int> numbers, TransformDelegate transform)
        {
            List<int> result = new();
            foreach (int n in numbers)
            {
                result.Add(transform(n));
            }
            return result;
        }

        public static bool IsEven(int n) => n % 2 == 0;
        public static bool IsPositive(int n) => n > 0;
        public static bool IsGreaterThanTen(int n) => n > 10;

        public static int Double(int n) => n * 2;
        public static int Square(int n) => n * n;
    }
}
