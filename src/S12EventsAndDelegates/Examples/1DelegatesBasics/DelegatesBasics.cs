namespace S12EventsAndDelegates.Examples._1DelegatesBasics;

public class DelegatesBasics
{
    public static void DelegatesBasicsMain()
    {
        // C# Built-in Delegates
        List<string> names = new List<string>() { "Baran", "Berkan", "Nat" };
        Console.WriteLine("Before");
        PrintEnumerable(names);
        
        Console.WriteLine("After");
        names.RemoveAll(Filter);
        PrintEnumerable(names);
    }
    
    static bool Filter(string s)
    {
        return s.ToLower().Contains("b");
    }

    static void PrintEnumerable<T>(IEnumerable<T> enumerable)
    {
        Console.WriteLine("Printing Enumerable Object");
        foreach (var element in enumerable)
        {
            Console.Write(element + "\t");
        }
        Console.WriteLine();
    }
}