namespace SessionDemo.BasicsDelegate
{
    public delegate int MathOperation(int a, int b);

    public class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
    }
}
