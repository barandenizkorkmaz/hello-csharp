namespace S21Threads.Topics._2ThreadStartAndEnd;

public class ThreadStartAndEnd
{
    public static void ThreadStartAndEndMain()
    {
        var taskCompletionSource = new TaskCompletionSource<bool>();

        var thread = new Thread(() =>
        {
            Console.WriteLine($"Thread with id {Thread.CurrentThread.ManagedThreadId} started...");
            Thread.Sleep(5000);
            taskCompletionSource.TrySetResult(true);
            Console.WriteLine($"Thread with id {Thread.CurrentThread.ManagedThreadId} ended...");
        });
        thread.Start();
        var test = taskCompletionSource.Task.Result;
        Console.WriteLine($"The result of task is {test}");
    }
}