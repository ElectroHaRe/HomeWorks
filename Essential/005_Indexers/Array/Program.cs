using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static int N;
        static Random rand = new Random();

        static void Main(string[] args)
        {
            start:

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Введите длинну массива: ");

            try
            {
                N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("Ввод не распознан");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                goto start;
            }

            if (N == 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("Длинна массива должна быть больше 0");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                goto start;
            }

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(-30000, 30000);
            }

            int maxValue = array[0];
            int minValue = array[0];
            int sumary = 0;
            int[] subArray = new int[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (maxValue < array[i])
                    maxValue = array[i];
                if (minValue > array[i])
                    minValue = array[i];
                sumary += array[i];
                if (array[i] % 2 != 0) {
                    System.Array.Resize(ref subArray, subArray.Length + 1);
                    subArray[subArray.Length - 1] = array[i];
                }
            }

            Console.SetCursorPosition(0, Console.CursorTop + 2);

            Console.WriteLine("Максимальное значение массива : {0}",maxValue);
            Console.WriteLine("Минимальное значение массива : {0}",minValue);
            Console.WriteLine("Сумма всех элементов массива : {0}",sumary);
            Console.WriteLine("Среднее арифметическое элементов массива : {0}",(double)sumary/array.Length);
            Console.Write("Все начётные элементы массива : ");
            for (int i = 0; i < subArray.Length; i++)
            {
                Console.Write(subArray[i]);
                if (i != subArray.Length - 1)
                    Console.Write(" , ");
                else Console.Write(" ;");
            }

            Console.SetCursorPosition(0, Console.CursorTop + 2);

            Console.WriteLine("1 - Continue | 2 - Exit");

            switch (Console.ReadLine())
            {
                case "1":
                case "Continue":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("_", 30);
                    Console.SetCursorPosition(0, Console.CursorTop + 2);
                    goto start;
                default:
                    break;
            }
        }
    }
}
