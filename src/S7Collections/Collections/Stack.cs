namespace S7Collections.Collections;

public class Stack
{
    public static void StackMain()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine($"The top element is {stack.Peek()}");
        int item = stack.Pop();

        while(stack.Count > 0){
            item = stack.Pop();
            // do stuff
        }
    }
}