using S12EventsAndDelegates.Examples._1DelegatesBasics;
using S12EventsAndDelegates.Examples._2CustomDelegates;
using S12EventsAndDelegates.Examples._3AnonymousMethods;
using S12EventsAndDelegates.Examples._4LambdaExpressions;

namespace S12EventsAndDelegates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, S12!");
        
        // Delegates Basics
        DelegatesBasics.DelegatesBasicsMain();
        
        // Custom Delegates
        CustomDelegates.CustomDelegatesMain();
        
        // Anonymous Methods
        AnonymousMethods.AnonymousMethodsMain();
        
        // Lambda Expressions
        LambdaExpressions.LambdaExpressionsMain();
        
    }


}