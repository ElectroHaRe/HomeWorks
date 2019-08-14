using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static int counter;

        static object block = new object();

        static void Task()
        {
            for (int i = 0; i < 100; i++)
            {
                lock (block)
                {
                    counter++;
                    Console.WriteLine("Task : {0} | counter : {1}",System.Threading.Tasks.Task.CurrentId,counter);
                }
            }
        }

        static async void TaskAsync()
        {
            await System.Threading.Tasks.Task.Factory.StartNew(Task);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                TaskAsync();
            }
            Console.ReadKey();
        }
    }
}
