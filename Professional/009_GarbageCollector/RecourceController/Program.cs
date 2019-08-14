using System;
using System.Text.RegularExpressions;

namespace RecourceController
{
    class Program
    {
        static bool interruptFilling = false;

        static void GarbageFilling()
        {
            byte[] temp = new byte[1024];
            while (!interruptFilling)
            {
                temp = new byte[temp.Length*2];
                Console.WriteLine("В данный момент занято памяти : {0} Кб",GC.GetTotalMemory(false)/1024);
                System.Threading.Thread.Sleep(1000);
            }
        }

        static string UserInputController(string keyPattern)
        {
            ConsoleKeyInfo key_info = Console.ReadKey(true);
            string user_input = String.Empty;
            while (key_info.Key!=ConsoleKey.Enter)
            {
                if (Regex.IsMatch(key_info.KeyChar.ToString(), keyPattern))
                {
                    Console.Write(key_info.KeyChar);
                    user_input += key_info.KeyChar;
                }
                key_info = Console.ReadKey(true);
            }
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            return user_input;
        }

        static void exceptionHandler(Exception e)
        {
            Console.WriteLine(new string('_',30));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();
            interruptFilling = true;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите допустимый объём памяти в килобайтах: ");
            ResourceController resource_controller = new ResourceController(Convert.ToInt64(UserInputController(@"\d"))*1024,exceptionHandler);
            resource_controller.StartMonitoring();
            GarbageFilling();
            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }
    }
}
