using S21Threads.Topics._1ThreadsBasics;
using S21Threads.Topics._2ThreadStartAndEnd;
using S21Threads.Topics._3ThreadPools;
using S21Threads.Topics._4ThreadsJoinAndIsAlive;

namespace S21Threads;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Threads!");
        
        // Threads: Basics
        ThreadsBasics.ThreadsBasicsMain();
        
        // Threads: Start and End
        ThreadStartAndEnd.ThreadStartAndEndMain();
        
        // Threads: Thread Pools
        ThreadPools.ThreadPoolsMain();
        
        // Threads: Join and IsAlive
        ThreadsJoinAndIsAlive.ThreadsJoinAndIsAliveMain();
        
        // Tasks
        Task.Run(() =>
        {
            Console.WriteLine("Task is running...");
            Console.WriteLine("Task has completed...");
        });
    }
}