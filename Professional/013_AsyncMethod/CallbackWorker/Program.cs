using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackWorker
{
    class Program
    {
        static Action action = () => { Console.WriteLine("Action started on {0} thread", Thread.CurrentThread.ManagedThreadId); Thread.Sleep(300); };

        // Callback метод может выполниться сильно раньше, нежели ты думаешь. EndInvoke просто говорит, что если выполнение подзадержалось, то необходимо его подождать
        static void Main(string[] args)
        {
            Console.WriteLine("Запускаем метод асинхронно...");
            Console.WriteLine(new string('_',30));
            IAsyncResult async_result = action.BeginInvoke((IAsyncResult result) => Console.WriteLine(result.AsyncState.ToString()), "Callback method has worked");
            Thread.Sleep(100);
            Console.WriteLine("_");
            Console.WriteLine("We still here");
            Console.WriteLine(new string('_', 30));
            action.EndInvoke(async_result);
            Console.ReadLine();
        }
    }
}
