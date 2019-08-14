using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoParallelMethods
{
    class Program
    {
        static object block = new object();

        static Action action1;
        static Action action2;

        static void Action1()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (block)
                {
                    Console.SetCursorPosition(20, i);
                    Console.WriteLine("action 1 | task : {0} | {1}", Task.CurrentId,i);
                }
            }
        }

        static void Action2()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (block)
                {
                    Console.SetCursorPosition(50, i);
                    Console.WriteLine("action 2 | task : {0} | {1}", Task.CurrentId, i);
                }
            }
        }

        static void Main(string[] args)
        {
            //(new Task(Action1)).Start();
            //(new Task(Action2)).Start();
            action1 = Action1;
            action2 = Action2;
            action1.BeginInvoke(null, null);
            action2.BeginInvoke(null, null);
            for (int i = 0; i < 1000; i++)
            {
                lock (block)
                {
                    Console.SetCursorPosition(0,i);
                    Console.WriteLine("Main here : {0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
