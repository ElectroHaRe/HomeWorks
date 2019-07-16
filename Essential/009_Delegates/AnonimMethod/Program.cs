using System;

namespace AnonimMethod
{
    public delegate int RandomValue();
    public delegate float Average(RandomValue[] rv);

    class Program
    {
        static RandomValue randomValueDelegate = () => { int result = rand.Next(-100, 100); Console.WriteLine("Результат работы делегата c сообщённым рандомизатором : {0}", result); return result; };

        static Average average = delegate (RandomValue[] rv)
        {
            float a = 0;
            for (int i = 0; i < rv.Length; i++)
            {
                a += rv[i]();
            }
            return a/rv.Length;
        };

        static Random rand = new Random();

        static void Main(string[] args)
        {
            start:

            float averageValue = 0;

            Console.WriteLine("Анонимный метод, пожалуйста, верни среднее арифметическое возвращаемых значений методов, сообщённых с элементами массива делегатов!");

            RandomValue[] rv = new RandomValue[10];

            for (int i = 0; i < rv.Length; i++)
            {
                rv[i] = randomValueDelegate;
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("Рандомные значения : ");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(new string('_',30));
            averageValue = average(rv);
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.WriteLine("Среднее арифметическое : {0}", averageValue);

            Console.WriteLine("1 - Повторить | 2 - Выйти");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(new string('_', 30));
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    goto start;
                default:
                    break;
            }
        }
    }
}
