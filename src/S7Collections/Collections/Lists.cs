namespace S7Collections.Collections;

public class Lists
{
    public static void ListsMain()
    {
        // List declaration
        List<int> numbers= new List<int>();
        //var numbers = new List<int>();
        //var numbers = new List<int>{1, 5, 35, 100};

        // Adding and removing values
        //var numbers = new List<int>();
        numbers.Add(7);
        numbers.Remove(7); // Removes the given element
        numbers.RemoveAt(0); // Removes an element at a specific index
        int value = numbers[0]; // Get element at index 0
        numbers.Clear(); // Deletes every element in our list

        // Lists and loops
        foreach(int element in numbers){
            // do stuff
        }

        for(int i = 0; i < numbers.Count; i++){
            // do stuff
        }
    }
}