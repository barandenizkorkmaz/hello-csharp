using System.Collections;
using System.Collections.Generic;
using S7Collections.Collections;

namespace S7Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        // Arrays
        Arrays.ArraysMain();
        
        // Multi-dimensional Arrays
        MultiDimensionalArrays.MultiDimensionalArraysMain();
        
        // Jagged Arrays
        JaggedArrays.JaggedArraysMain();
        
        int num1 = 5;
        float num2 = 3.14f;
        string name = "Denis";
        ArrayList myArrList = new ArrayList();
        myArrList.Add(num1);
        myArrList.Add(num2);
        myArrList.Add(name);
        
        // Generic Collections
        string animal1 = "Cat";
        string animal2 = "Dog";
        string animal3 = "Flamingo";
        List<string> myList = new List<string>();
        myList.Add(animal1);
        myList.Add(animal2);
        myList.Add(animal3);
        
        // ArrayLists
        ArrayLists.ArrayListsMain();
        
        // Params
        ParamsMethod("This", "is", "a", "long", "sentence", "...");
        ParamsMethod2("This", "is", "a", "long", "sentence", "...", 3, 3.14, false);
        Console.WriteLine(Sum(1, 3, 5));
        Console.WriteLine(Average(1, 3, 5));
        
        // HashTables
        HashTables.HashTablesMain();
        
        // Dictionaries
        Dictionaries.DictionariesMain();
        
        
    }

    public static void ParamsMethod(params string[] sentence)
    {
        foreach(string word in sentence)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
    
    public static void ParamsMethod2(params object[] objects)
    {
        foreach(object item in objects)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    
    public static int Sum(params int[] nums)
    {
        int sum = 0;
        foreach (int number in nums)
        {
            sum += number;
        }
        return sum;
    }

    public static double Average(params int[] nums)
    {
        int sum = 0, count = 0;
        foreach (int num in nums)
        {
            sum += num;
            count++;
        }

        return (double)sum / count;
    }
    
}