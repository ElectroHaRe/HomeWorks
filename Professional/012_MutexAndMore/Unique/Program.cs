using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique
{
    class Program
    {
        static Mutex mutex = new Mutex(false,"GLOBAL::MyMutexFromUnique");
        static int a = 0;

        static void Task()
        {
            mutex.WaitOne();
            a++;
            Console.WriteLine("Поток {0} получил доступ к ресурсу | {1}", Thread.CurrentThread.ManagedThreadId, a);
            Thread.Sleep(500);
            mutex.ReleaseMutex();
        }

        static void Main(string[] args)
        {
            if (mutex.WaitOne(0))
            {
                a++;
                Console.WriteLine("Поток {0} получил доступ к ресурсу | {1}", Thread.CurrentThread.ManagedThreadId, a);
                Console.WriteLine("Теперь, пока вы не закроете приложение, хапустить новое у вас не то чтобы получится)");
                Console.ReadKey();
                mutex.ReleaseMutex();
            }
        }
    }
}
