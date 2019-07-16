using System;
using System.Threading;

namespace _013_Threads
{
    class Program
    {
        static Random rand = new Random();

        static object locker = new object();

        static int[] ThreadsCharLength = new int[Console.WindowWidth];

        static int[] HeadPosition = new int[Console.WindowWidth];

        static Thread[] threads = new Thread[Console.WindowWidth];

        static char[] GenerateCharArray(int length)
        {
            char[] temp = new char[length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = (char)rand.Next(64, 95);
            }
            if (length > 0)
                temp[temp.Length - 1] = ' ';
            return temp;
        }

        static int GenerateLength()
        {
            return rand.Next(0, 20);
        }

        static void PrintCharWithColor(char[] items, int index)
        {
            switch (index)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
            }
            Console.Write(items[index]);
        }

        static void DoMatrix()
        {
            bool firstRunComplete = false;

            for (; ; )
            {
                int index = 0;

                for (int i = 0; i < threads.Length; i++)
                {
                    if (threads[i] != null && threads[i].Equals(Thread.CurrentThread))
                        index = i;
                }

                char[] temp = GenerateCharArray(ThreadsCharLength[index]);

                Thread.Sleep(rand.Next(10, 500));

                lock (locker)
                {
                    for (int i = 0; i < temp.Length; i++)
                    {
                        int height = 0;

                        if (HeadPosition[index] - i >= 0 && HeadPosition[index] - i <= Console.WindowHeight)
                            height = HeadPosition[index] - i;

                        else if (firstRunComplete)
                            height = HeadPosition[index] - i + Console.WindowHeight;

                        else height = 0;

                        Console.SetCursorPosition(index/2, height);
                        PrintCharWithColor(temp, i);
                    }

                    HeadPosition[index]++;

                    if (HeadPosition[index] >= Console.WindowHeight)
                    {
                        HeadPosition[index] = 0;
                        firstRunComplete = true;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < ThreadsCharLength.Length; i++)
            {
                ThreadsCharLength[i] = GenerateLength();
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(DoMatrix);
                threads[i].Start();
            }
        }
    }
}
