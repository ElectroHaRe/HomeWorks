using System;

namespace EmployeePosition
{
    enum Post:int
    {
        One = 600,
        two = 800,
        three = 1200
    }

    static class Accauntant {

        public static bool AskForBonus(Post worker, int hours)
        {
            return hours > (int)worker;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            start:

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Укажите должность сотрудника ( {0} - {1} | {2} - {3} | {3} - {4} ) : ", 1,Post.One,2, Post.two,3, Post.three);
            int choise;
            try
            {
                choise = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                goto Error;
            }

            Post post;

            switch (choise)
            {
                case 1:
                    post = Post.One;
                    break;
                case 2:
                    post = Post.two;
                    break;
                case 3:
                    post = Post.three;
                    break;
                default:
                    goto Error;
            }

            Console.Write("Укажите количество отработанных часов : ");
            try
            {
                choise = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                goto Error;
            }

            if (Accauntant.AskForBonus(post, choise))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.Write("Сотрудник заслужил премию. Выдать её немедленно!");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 2);
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.Write("Сотруднику не положена премия в этом месяце!");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("_", 30);
                Console.SetCursorPosition(0, Console.CursorTop + 2);
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
