namespace S7Collections.Collections;

public class Arrays
{
    public static void ArraysMain()
    {
        int[] grades = new int[5];
        
        // initializing array members one by one 
        grades[0] = 20;
        Console.WriteLine($"Grade at index 0 is {grades[0]}");
        
        string input = Console.ReadLine();
        grades[0] = int.Parse(input);
        
        // another way of initializing an array
        int[] gradesOfMathStudentsA = {20, 12, 70, 55};
        
        // third way of initializing an array
        int[] gradesOfMathStudentsB = new int[] {57, 90, 76, 86};
        
        Console.WriteLine($"Length of gradesOfMathStudentsA: {gradesOfMathStudentsA.Length}");
        
        int[] nums = {1,2,3,4,5};
        int counter = 0;
        foreach(int num in nums)
        {
            Console.WriteLine("Element{0} is {1}", counter++, num);
        }
    }
}