namespace S21Threads.Topics._1ThreadsBasics;

public class ThreadsBasics
{
    public static void ThreadsBasicsMain()
    {
        /*
         * Threads: Basics
         */
        new Thread(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread 1");
        }).Start();
        new Thread(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread 2");
        }).Start();
        new Thread(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread 3");
        }).Start();
        new Thread(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread 4");
        }).Start();
    }
}