namespace S21Threads.Topics._4ThreadsJoinAndIsAlive;

public class ThreadsJoinAndIsAlive
{
    public static void ThreadsJoinAndIsAliveMain()
    {
        Console.WriteLine("Main thread started...");
        Thread thread1 = new Thread(Thread1Function);
        Thread thread2 = new Thread(Thread2Function);
        thread1.Start();
        thread2.Start();
        if (thread1.Join(1000))
        {
            Console.WriteLine("Thread1 is done within 1 sec...");
        }
        else
        {
            Console.WriteLine("Thread1 was not done within 1 sec...");
        }
        thread2.Join();
        Console.WriteLine("Thread2 joined...");

        if (thread1.IsAlive)
        {
            Console.WriteLine("Thread1 is still running...");
        }
        else
        {
            Console.WriteLine("Thread1 has completed...");
        }

        while (thread1.IsAlive)
        {
            Console.WriteLine("Thread1 is still executing...");
            Thread.Sleep(300);
        }
        Console.WriteLine("Thread1 has terminated...");
        
        Console.WriteLine("Main thread ended...");
    }

    public static void Thread1Function()
    {
        Console.WriteLine("Function 1: Start");
        Thread.Sleep(5000);
        Console.WriteLine("Function 2: End");
        
    }

    public static void Thread2Function()
    {
        Console.WriteLine("Function 2: Start");
        Console.WriteLine("Function 2: End");
    }
}