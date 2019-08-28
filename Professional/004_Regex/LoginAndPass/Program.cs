using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace LoginAndPass
{

    public class s
    {
        public static int a;
        public dynamic b;

        public delegate dynamic meh(dynamic arg);
        //public event dynamic lol;//ошибка

        dynamic m(dynamic arg) { return 5; }
    }

    //interface dynamucTest<T> { }

    //class dTest<T> { }

    //class p2 : dTest<dynamic> { }

    //class p : Program,dynamucTest<dynamic>//ошибка
    //{
    //    public override int this[int a] => base[a];
    //}

    class Program
    {
        public virtual int this[int a] { get => 3; }

        volatile s a;

        static string ReadLineWithPattern(string pattern)
        {
            string line = "";
            string current = "";
            ConsoleKeyInfo keyInfo;
            int left_border = Console.CursorLeft;
            while (true)
            {
                keyInfo = Console.ReadKey(true);
                current = keyInfo.KeyChar.ToString();
                if (keyInfo.Key == ConsoleKey.Backspace && left_border < Console.CursorLeft)
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(" ");
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    line = line.Remove(line.Length - 1);
                }
                if (Regex.IsMatch(current, pattern))
                {
                    Console.Write(current);
                    line += current;
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    return line;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите логин : ");
            string login = ReadLineWithPattern("^[A-Za-z]+$");
            Console.Write("Ввелите пароль : ");
            string pass = ReadLineWithPattern("^[A-z0-9]+$");
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Ваш логин : {0}", login);
            Console.WriteLine("Ваш пароль : {0}", pass);
            Console.ReadKey();
            
        }
    }
}
