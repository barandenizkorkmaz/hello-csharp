namespace S21Threads.Topics._3ThreadPools;

public class ThreadPools
{
    public static void ThreadPoolsMain()
    {
        // First observe below that threads are difficult to control and one must be careful working with them.
        /*
        Enumerable.Range(0, 1000).ToList().ForEach(i =>
        {
            new Thread(() =>
            {
                Console.WriteLine($"Thread with id {Thread.CurrentThread.ManagedThreadId} started...");
                Thread.Sleep(1000);
                Console.WriteLine($"Thread with id {Thread.CurrentThread.ManagedThreadId} ended...");            
            }).Start();
        });
        */
        
        
        // Thread pools makes threads more controllable and are more secure way of using threads
        Enumerable.Range(0, 1000).ToList().ForEach(i =>
        {
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Console.WriteLine($"Thread with id {Thread.CurrentThread.ManagedThreadId} started...");
                Thread.Sleep(1000);
                Console.WriteLine($"Thread with id {Thread.CurrentThread.ManagedThreadId} ended...");
            });
        });
    }
}