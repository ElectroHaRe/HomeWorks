using System;
using System.Threading;

namespace SemaphoreAndLogFile
{
    class Program
    {

        static Semaphore temp = new Semaphore(3, 5);

        static void Task()
        {
            temp.WaitOne();
            Console.WriteLine("Поток {0} получил доступ к ресурсу",Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Поток {0} освободил ресурс -------->", Thread.CurrentThread.ManagedThreadId);
            temp.Release();
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                (new Thread(Task)).Start();
            }
            Console.ReadKey();
        }
    }
}
