using System;
using System.Threading;

namespace Counter
{
    class Program
    {
        static object block= new object();
        static int counter;

        static void Task()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (block)
                {
                    counter++;
                    Console.WriteLine("counter = {0} | Поток : {1}", counter, Thread.CurrentThread.ManagedThreadId);
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                (new Thread(Task)).Start();
            }
            Console.ReadKey();
        }
    }
}
