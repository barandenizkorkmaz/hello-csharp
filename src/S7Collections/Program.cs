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
    }
}