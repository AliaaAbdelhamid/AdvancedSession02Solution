namespace SessionDemo.MulticastDelegates
{
    public delegate void NotifyDelegate(string message);

    public class NotificationService
    {
        public static void SendEmail(string message)
        {
            Console.WriteLine($"  [EMAIL] Sending: {message}");
        }

        public static void SendSMS(string message)
        {
            Console.WriteLine($"  [SMS] Sending: {message}");
        }

        public static void SendPush(string message)
        {
            Console.WriteLine($"  [PUSH] Sending: {message}");
        }

        public static void LogToConsole(string message)
        {
            Console.WriteLine($"  [LOG] {message}");
        }
    }
}
