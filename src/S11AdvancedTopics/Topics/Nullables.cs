namespace S11AdvancedTopics.Topics;

public class Nullables
{
    public static void NullablesMain()
    {
        int? num1 = null;
        // int num2 = null; // compiler error
        int num5;
        
        Console.WriteLine(num1); // ok
        // Console.WriteLine(num5); // compiler error - error accessing an uninitialized non-null variable
        
        double? num3 = new Double?();
        double? num4 = 3.1415;
        
        bool? _bool = new bool?();
        
        bool? isMale = null;
        if(isMale ?? false){
            Console.WriteLine("User is male");
        }
        else if(!isMale ?? false){
            Console.WriteLine("User is female");
        }
        else{ // will enter here!
            Console.WriteLine("No gender specified");
        }
        
        double? num6 = 13.1;
        double? num7 = null;
        double num8;
        
        if(num6 == null){
            num8 = 0.0;
        }
        else{
            num8 = (double)num6; // We need type casting here since type double != double?
        }
        // We can also do it shortly using null coalescing (??) operator.
        num8 = num6 ?? 8.53; // If num6 is not null take the value of num6, otherwise 8.53.
        
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}