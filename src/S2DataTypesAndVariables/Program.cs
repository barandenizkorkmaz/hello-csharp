namespace S2DataTypesAndVariables;

class Program
{
    static void Main(string[] args)
    {
        // Data types and Their Limits
        sbyte num1 = 120; // signed 8 bits
        short num2 = 30000; // signed 16 bits
        int num3 = 200000; // signed 32 bits
        long num4 = 9223372036854775807; // signed 64 bits

        float num5 = 99.99f; // 32 bits 7-digit precision
        double num6 = 1.5d; // 64 bits 15-digit precision
        decimal num7 = 1.521093891283021m; // 128 bits 28-digit precision
        
        bool _bool1 = false;
        char singleLetter = 'A';

        string username = "denizkorkmaz";
        
        Console.WriteLine("Hello, S2!");
    }
}