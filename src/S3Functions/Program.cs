namespace S3Functions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, S3!");
        
        // Methods
        WriteSomething();
        WriteSomethingSpecific("I am an argument and am called from a method");
        
        // Parameters
        Console.WriteLine(Divide(25,13));
        
        // Operators
        int num1 = 5;
        int num2 = 3;
        int num3;

        // unary operators
        num3 = -num1;
        Console.WriteLine("num3 is {0}",num3 );

        bool isSunny = true;
        Console.WriteLine("is it sunny? {0}", !isSunny);

        // increment operators
        int num = 0;
        num++;
        Console.WriteLine("num is {0}", num);
        Console.WriteLine("num is {0}", num++);
        // pre increment
        Console.WriteLine("num is {0}", ++num);

        // decrement operator
        num--;
        Console.WriteLine("num is {0}", num);
        Console.WriteLine("num is {0}", num--);
        // pre decrement
        Console.WriteLine("num is {0}", --num);

        int result;

        result = num1 + num2;
        Console.WriteLine("result of num1 + num2 is {0}", result);
        result = num1 - num2;
        Console.WriteLine("result of num1 - num2 is {0}", result);
        result = num1 / num2;
        Console.WriteLine("result of num1 / num2 is {0}", result);
        result = num1 * num2;
        Console.WriteLine("result of num1 * num2 is {0}", result);
        result = num1 % num2;
        Console.WriteLine("result of num1 % num2 is {0}", result);

        // relational and type operators
        bool isLower;
        isLower = num1 < num2;
        Console.WriteLine("result of num1 < num2 is {0}", isLower);

        // equality operator
        bool isEqual;
        isEqual = num1 == num2;
        Console.WriteLine("result of num1 == num2 is {0}", isEqual);

        isEqual = num1 != num2;
        Console.WriteLine("result of num1 != num2 is {0}", isEqual);

        // conditional operators
        bool isLowerAndSunny;
        // condition1 AND condition2
        isLowerAndSunny = isLower && isSunny;
        Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

        // condition1 OR condition2
        isLowerAndSunny = isLower || isSunny;
        Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);
        Console.ReadKey();
    }
    
    // access modifier (static) return type method name (parameter1, parameter2)
    public static void WriteSomething()
    {
        Console.WriteLine("I am called from a method");
    }

    public static void WriteSomethingSpecific(string myText)
    {
        Console.WriteLine(myText);
    }
    
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public static double Divide(double num1, double num2)
    {
        return num1 / num2;
    }

    public static void Calculate()
    {
        Console.WriteLine("Please enter the first number...");
        string number1 = Console.ReadLine();
        Console.WriteLine("Please enter the second number...");
        string number2 = Console.ReadLine();

        int num1 = int.Parse(number1);
        int num2 = int.Parse(number2);
        int result;
        
        try
        {
            result = num1 / num2;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by zero!");
        }




        string userInput = Console.ReadLine();
        try
        {
            int userInputAsInt = int.Parse(userInput);
        }
        catch (FormatException)
        {
            Console.WriteLine("Format exception, please enter the correct type next time.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("ArgumentNullException, the value was empty(null)");
        }
        finally
        {
            Console.WriteLine("This is called anyways!");
        }

    }
}