namespace SessionDemo
{
    public static class Helper
    {

        public static void PrintList<T>(string listName, List<T> list)
        {
            Console.WriteLine($"{listName}: [{string.Join(", ", list)}]\n");

        }
    }
}
