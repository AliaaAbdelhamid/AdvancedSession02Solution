namespace SessionDemo.MulticastReturnValues
{
    public delegate int ProcessDelegate(int value);

    public class Processor
    {
        public static int AddTen(int value)
        {
            return value + 10;
        }

        public static int MultiplyByTwo(int value)
        {
            return value * 2;
        }
    }
}
