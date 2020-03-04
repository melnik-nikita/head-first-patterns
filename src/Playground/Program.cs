using System;
using System.Threading;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(someFunc);
            t.Name = "Thread1";
            t.IsBackground = true;
            t.Start();
            Console.WriteLine("Main thread Running");
            Console.ReadKey();
        }

        static void someFunc()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} started");
            Thread.Sleep(2000);
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} completed");
        }
    }
}