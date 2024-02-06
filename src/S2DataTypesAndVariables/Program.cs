namespace S2DataTypesAndVariables;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, S2!");
        
        // Data types and Their Limits
        /*
         * References
         * - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#83-value-types
         * - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#835-simple-types
         */
        sbyte num1 = 120; // signed 8 bits
        short num2 = 30000; // signed 16 bits
        int num3 = 200000; // signed 32 bits
        long num4 = 9223372036854775807; // signed 64 bits

        float num5 = 99.99f; // 32 bits 7-digit precision
        double num6 = 1.5d; // 64 bits 15-digit precision
        double num8 = 1.5; // omitting postfix defaults to double
        decimal num7 = 1.521093891283021m; // 128 bits 28-digit precision
        
        bool _bool1 = false;
        char singleLetter = 'A';

        string username = "denizkorkmaz";
        
        // String and Methods
        string name = "Deniz";
        string message = "My name is " + name;
        string upperCaseMessage = message.ToUpper();
        string lowerCaseMessage = message.ToLower();
        Console.WriteLine(message);
        Console.WriteLine(lowerCaseMessage);
        Console.WriteLine(upperCaseMessage);
        Console.WriteLine(message.Length);
        
        // Class: Console
        Console.Write("text here");
        Console.WriteLine("text here");
        // int readReturn = Console.Read(); // Takes a single input of type string and returns the ASCII value of that input
        // Console.WriteLine($"ASCII value of entered value is {readReturn}");
        // Console.ReadLine(); // Takes a string or integer input and returns it as the Output value
        // Console.ReadKey(); // Takes a single input of type string and returns it as Key Info
        
        // C# Naming Conventions and Coding Standards
        // Reference: https://www.dofactory.com/csharp-coding-standards
        
        /*
         * Class names like ClientActivity
         * Method name like CalculateValue
         * Method arguments like firstNumber
         *
         * local variables like itemCount
         * use userControl instead of userCtrl
         * don't use numbers in the beginning of variable names
         *
         */
        
        // Correct
        string myName;
        int lastNum;
        bool isSaved;
        
        /*
         * Avoid
         * String myName;
         * Int32 lastNum;
         * Boolean isSaved;
         */
        
        // Implicit and Explicit Conversion
        // impicit conversion
        int num = 12390532;
        long bigNum = num;

        float myFloat = 13.37F;
        double myNewDouble = myFloat;

        double myDouble = 13.37;
        int myInt;
        
        // explicit conversion
        // cast double to int;
        myInt = (int)myDouble;

        // typeConversion 
        string str1 = myDouble.ToString(); // "13.37"
        string myFloatString = myFloat.ToString();
        bool sunIsShining = false;

        string myBoolString = sunIsShining.ToString();

        Console.WriteLine(myBoolString);
        
        string str2 = "15";
        string str3 = "13";
        int num9 = Int32.Parse(str2);
        int num10 = Int32.Parse(str3);
        int resultInt = num9 + num10;
        string result = str2 + str3;

        Console.WriteLine(resultInt);
        Console.WriteLine(result);
        
        // String Manipulation
        int age = 26;

        // String Concatenation
        Console.WriteLine("Name: + " + name + " Age: " + age);
        Console.WriteLine("String formatting...");
        Console.WriteLine("Name: {0}\tAge:{1}", name, age);
        Console.WriteLine("String Interpolation...");
        Console.WriteLine($"Name: {name}\tAge: {age}");
        Console.WriteLine("Verbatim Strings...");
        Console.WriteLine(@"Lorem ipsum
        Lorem ipsum
        Lorem ipsum
        Lorem ipsum
        Lorem ipsum
        Lorem ipsum
        ");
        // Instead of \\ to write file paths, you can use verbatim strings
        Console.WriteLine(@"C:\User\Korkmaz\Git\Dev\README.md");
        Console.WriteLine(@"With verbatim strings \n Even valid escape characters won't work!");
        
        // More String Methods
        // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.string?view=net-8.0
        /*
         * SubString(int32)
         * ToLower()
         * ToUpper()
         * Trim()
         * IndexOf(string): Get the first occurence of the string or character inside the string.
         * IsNullOrWhiteSpace()
         */
        
        // Implicitly Typed Local Variables
        var text = "Text"; // string
        Console.WriteLine(text.ToUpper());
        var number = 0; // int
        var isValid = false; // boolan
        // var newVar = null; // cannot assign null variables to variables declared using 'var'
        
        // Constants
        const double PI = 3.14159265;
        const int days = 365, weeks = 52, months = 12;
        
        /*
         * ref keyword & Generic Collections
         */
        int[] xs = [10, 20, 30, 40];
        Console.WriteLine("Before:");
        PrintCollection(xs);
        
        Console.WriteLine("After:");
        ref int item = ref xs[1];
        item = 60;
        PrintCollection(xs);
        
        ref int found = ref FindFirst(xs, s => s == 30);
        int found2 = FindFirst(xs, s => s == 30);
        found = 40;
        PrintCollection(xs);
        found2 = 80; // Note that it has no effect!
        // The caller can then choose to treat the returned variable
        // as if it were returned by value or by reference.
        // Methods returning by reference can't have the return type void.
        PrintCollection(xs);
    }
    
    public static void PrintCollection<T>(IEnumerable<T> collection)
    {
      foreach (var item in collection)
      {
       Console.Write($"{item} ");
      }
      Console.WriteLine();
    }
    
    public static ref int FindFirst(int[] numbers, Func<int, bool> predicate)
    {
      for (int i = 0; i < numbers.Length; i++)
      {
        if (predicate(numbers[i]))
        {
          return ref numbers[i];
        }
      }
      throw new InvalidOperationException("No element satisfies the given condition.");
    }
}