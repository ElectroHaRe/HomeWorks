using System;

namespace ColorPrint
{

    enum Color : byte {
        Blue,
        Gray,
        Green,
        Red,
        White,
        Yellow
    }

    class Program
    {
        static int Print(string stroka, byte color) {
            switch (color)
            {
                case (byte)Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (byte)Color.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case (byte)Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (byte)Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (byte)Color.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case (byte)Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.WriteLine("_",30);
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.Write("Ввод не распознан");
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.WriteLine("_", 30);
                    Console.SetCursorPosition(0, Console.CursorTop + 2);
                    return 1;
            }
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("_", 30);
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write(stroka);
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("_", 30);
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            return 0;
        }

        static void Main(string[] args)
        {
            start:

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Введите необходимую строку : ");
            string stroka = Console.ReadLine();
            if (stroka.Length == 0)
                goto Error;
            Console.Write("Выберите необходимый цвет : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("{0} - {1} | ", (byte)Color.Blue, Color.Blue);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("{0} - {1} | ", (byte)Color.Gray, Color.Gray);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("{0} - {1} | ", (byte)Color.Green, Color.Green);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0} - {1} | ", (byte)Color.Red, Color.Red);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0} - {1} | ", (byte)Color.White, Color.White);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0} - {1} | ", (byte)Color.Yellow, Color.Yellow);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            try
            {
                Print(stroka, Convert.ToByte(Console.ReadLine()));
            }
            catch {
                goto Error;
            }

            goto start;

            Error:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("_", 30);
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write("Ввод не распознан");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("_", 30);
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            goto start;
        }
    }
}
