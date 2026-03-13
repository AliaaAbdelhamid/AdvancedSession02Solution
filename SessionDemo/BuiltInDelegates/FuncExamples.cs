namespace SessionDemo.BuiltInDelegates
{
    internal class FuncExamples
    {
        public static int GetRandomNumber()
        {
            return new Random().Next(1, 100);
        }

        public static int Square(int n)
        {
            return n * n;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
