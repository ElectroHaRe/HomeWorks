using System;

namespace _009_Delegates
{
    public delegate float ArifOperation(float a, float b);

    class Program
    {
        static ArifOperation ArifDelegate = null;

        static float Add(float a, float b) => a + b; //лямбда выражение
        static float Sub(float a, float b) => a - b; //лямбда выражение
        static ArifOperation Mul = (a, b) => {return a * b; };// лямбда оператор
        static ArifOperation Div = (a, b) => {
                if (b == 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.WriteLine(new string('_', 30));
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.WriteLine("Ошибка деления но ноль");
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.WriteLine(new string('_', 30));
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                }
                return a / b;
            }; // Лямбда оператор

        static void Main(string[] args)
        {
            start:

            float a, b= 0;
            string sign = "";
            ArifDelegate = null;

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Калькулятор");

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.Write("Введите первое число : ");

            try
            {
                a = Convert.ToSingle(Console.ReadLine());
            }
            catch {
                goto InputError;
            }

            Console.Write("Введите арифметический знак ( + | - | * | / ) : ");

            switch (sign = Console.ReadLine())
            {
                case "+":
                    ArifDelegate = Add;
                    break;
                case "-":
                    ArifDelegate = Sub;
                    break;
                case "*":
                    ArifDelegate = Mul;
                    break;
                case "/":
                    ArifDelegate = Div;
                    break;
                default:
                    goto InputError;
            }

            Console.Write("Введите второе число : ");

            try
            {
                b = Convert.ToSingle(Console.ReadLine());
            }
            catch {
                goto InputError;
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.WriteLine("Результат : {0} {1} {2} = {3}",a,sign,b,ArifDelegate(a,b));

            goto end;

            InputError:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("Ввод не распознан");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            goto start;

            end:
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("1 - Повторить ввод | 2 - Выход");

            switch (Console.ReadLine()) {
                case "1":
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.WriteLine(new string('_', 30));
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    goto start;
                default:
                    break;
            }
        }
    }
}
