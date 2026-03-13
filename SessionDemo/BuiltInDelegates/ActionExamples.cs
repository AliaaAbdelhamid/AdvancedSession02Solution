namespace SessionDemo.BuiltInDelegates
{
    internal class ActionExamples
    {
        public static void Greet()
        {
            Console.WriteLine("  Hello!");
        }

        public static void GreetPerson(string name)
        {
            Console.WriteLine($"  Hello, {name}!");
        }

        public static void GreetWithAge(string name, int age)
        {
            Console.WriteLine($"  Hello, {name}! You are {age} years old.");
        }
    }
}
