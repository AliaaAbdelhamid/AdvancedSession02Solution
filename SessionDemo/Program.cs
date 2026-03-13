namespace SessionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basics Delegate [Calculator Example]

            //int a = 10, b = 5;

            //MathOperation add = Calculator.Add;
            //Console.WriteLine($"add(a, b) = {add(a, b)}");

            //MathOperation subtract = Calculator.Subtract;
            //Console.WriteLine($"subtract(a, b) = {subtract(a, b)}");

            //// Reassigning delegate

            //MathOperation operation = Calculator.Add;
            //Console.WriteLine($"operation(10, 5) = {operation(10, 5)}");

            //operation = Calculator.Subtract;
            //Console.WriteLine($"operation(10, 5) = {operation(10, 5)}");

            #endregion

            #region Delegates as Method Parameters

            //List<int> numbers = new() { 1, -2, 3, -4, 5, 12, 7, 15 };
            //Helper.PrintList("Numbers", numbers);

            //List<int> evens = NumberProcessor.Filter(numbers, NumberProcessor.IsEven);
            //Helper.PrintList("Filter(IsEven)", evens);

            //List<int> positives = NumberProcessor.Filter(numbers, NumberProcessor.IsPositive);
            //Helper.PrintList("Filter(IsPositive)", positives);

            //List<int> greaterThan10 = NumberProcessor.Filter(numbers, NumberProcessor.IsGreaterThanTen);
            //Helper.PrintList("Filter(IsGreaterThanTen)", greaterThan10);

            //List<int> doubled = NumberProcessor.Transform(numbers, NumberProcessor.Double);
            //Helper.PrintList("Transform(Double)", doubled);

            //List<int> squared = NumberProcessor.Transform(numbers, NumberProcessor.Square);
            //Helper.PrintList("Transform(square)", squared);
            #endregion

            #region Multicast Delegates

            //NotifyDelegate notify = NotificationService.SendEmail;
            //notify += NotificationService.SendSMS;
            //notify += NotificationService.SendPush;

            //// Invoking multicast delegate
            //notify("Order confirmed!");
            //Console.WriteLine("==========================");
            //// Removing SMS from chain
            //notify -= NotificationService.SendSMS;
            //notify("Order shipped!");

            //Console.WriteLine("==========================");
            //// Adding more handlers
            //notify += NotificationService.LogToConsole;
            //notify("Order delivered!");

            #endregion

            #region Multicast Return Values

            //ProcessDelegate process = Processor.AddTen;
            //process += Processor.MultiplyByTwo;

            //int input = 5;
            //int result = process(input);
            //Console.WriteLine($"Result: {result}"); // 10

            //// To get ALL return values, iterate manually 
            //Delegate[] delegates = process.GetInvocationList();
            //Console.WriteLine($"Invocation list has {delegates.Length} methods:"); // 2
            //foreach (ProcessDelegate del in delegates)
            //{
            //    int res = del(input);
            //    Console.WriteLine($"  Result: {res}");
            //}

            #endregion

            #region Built-in Delegates - Action

            //Action greet = ActionExamples.Greet;
            //greet();

            //Action<string> greetPerson = ActionExamples.GreetPerson;
            //greetPerson("Mohamed");

            //Action<string, int> greetWithAge = ActionExamples.GreetWithAge;
            //greetWithAge("Salma", 25);

            //// Using Action with List.ForEach
            //List<int> numbers = new() { 1, 2, 3, 4, 5 };
            //numbers.ForEach(PrintSquareNumber);

            #endregion

            #region Built-in Delegates - Func

            //Func<int> getRandomNumber = FuncExamples.GetRandomNumber;
            //Console.WriteLine($"getRandomNumber(): {getRandomNumber()}");

            //Func<int, int> square = FuncExamples.Square;
            //Console.WriteLine($"square(7): {square(7)}");

            //Func<int, int, int> addFunc = FuncExamples.Add;
            //Console.WriteLine($"add(10, 20): {addFunc(10, 20)}");

            //Func<int, bool> isEven = FuncExamples.IsEven;
            //Console.WriteLine($"isEven(4): {isEven(4)}, isEven(5): {isEven(5)}");

            #endregion

            #region Built-in Delegates - Predicate

            //Predicate<int> isPositive = PredicateExamples.IsPositive;
            //Predicate<string> isLong = PredicateExamples.IsLong;

            //Console.WriteLine(isPositive(5));   // True
            //Console.WriteLine(isPositive(-2));  // False

            //Console.WriteLine(isLong("Hello"));       // False
            //Console.WriteLine(isLong("Programming")); // True

            //// Using Predicate with List methods

            //List<int> numbers = new() { -5, 3, -2, 8, -1, 9, 4 };
            //Helper.PrintList("Numbers", numbers);

            //Predicate<int> isNegative = PredicateExamples.IsNegative;
            //List<int> negatives = numbers.FindAll(isNegative);
            //Helper.PrintList("Find All Negative Numbers ", negatives);

            //bool anyNegative = numbers.Exists(isNegative);
            //Console.WriteLine($"Any Negative Number : {anyNegative}");

            //int firstNegative = numbers.Find(isNegative);
            //Console.WriteLine($"First Negative Number : {firstNegative}");

            //int lastNegative = numbers.FindLast(isNegative);
            //Console.WriteLine($"Last Negative Number : {lastNegative}");

            #endregion

            #region Anonymous Methods And Lambda Expressions

            //// Syntax: delegate(parameters) { body }

            //Action<string> greetPerson = ActionExamples.GreetPerson;
            //greetPerson = delegate (string name) { Console.WriteLine($"Hello, {name}!"); }; //Anonymous Method
            //greetPerson = name => Console.WriteLine($"Hello, {name}!"); // Lambda Expressions
            //greetPerson("Mohamed");

            //Func<int, int, int> addFunc = FuncExamples.Add;
            //addFunc = delegate (int x, int y) { return x + y; }; // Anonymous Method
            //addFunc = (x, y) => x + y; // Lambda Expressions
            //Console.WriteLine($"add(10, 20): {addFunc(10, 20)}");

            //Predicate<int> isPositive = PredicateExamples.IsPositive;
            //isPositive = delegate (int n) { return n > 0; }; // Anonymous Method
            //isPositive = n => n > 0; // Lambda Expressions
            //Console.WriteLine(isPositive(5));   // True

            #endregion

            #region Lambda Closures

            #region Problem 
            //List<Func<bool>> checks = new();

            //for (int i = 1; i <= 3; i++)
            //{
            //    checks.Add(() => i % 2 == 0);
            //}

            //foreach (var check in checks)
            //{
            //    Console.WriteLine(check()); // true , true , true 
            //}
            #endregion

            #region Solution
            //List<Func<bool>> checks = new();

            //for (int i = 1; i <= 3; i++)
            //{
            //    int copy = i;

            //    checks.Add(() => copy % 2 == 0);
            //}

            //foreach (var check in checks)
            //{
            //    Console.WriteLine(check()); // false , true , false 
            //}
            #endregion

            #endregion
        }

        public static void PrintSquareNumber(int num)
        {
            Console.WriteLine($"{num}^2 = {Math.Pow(num, 2)}");
        }

    }
}
