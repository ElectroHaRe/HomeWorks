using System;
using System.Collections.Generic;

namespace _15_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerList list = new WorkerList();

            start:
            ((IEnumerator<Worker>)list).Reset();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Работа с колекцией работников");
            Console.WriteLine(new string('_', 30));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(" [1] - зарегистрировать сотрудника в системе |" +
                "\n [2] - Вывести полный список сотрудников |" +
                "\n [3] - Показать сотрудников со стажем более ... | " +
                "\n [4] - Удалить запись о сотруднике из иситемы");
            Console.WriteLine();
            Console.Write("Выберите интересующий вас пункт меню : ");
            byte choise = 0;
            try { choise = Convert.ToByte(Console.ReadLine()); }
            catch { goto InputError; }

            switch (choise)
            {
                case 1:
                    goto AddWorkerMenu;
                case 2:
                    goto ShowWorkersMenu;
                case 3:
                    goto ShowWorkersByLengthMenu;
                case 4:
                    goto DeleteWorker;
                default:
                    goto InputError;
            }

            DeleteWorker:

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(new string('_', 30));
            if (list.size > 0)
                Console.WriteLine("Список сотрудников : ");
            else
            {
                Console.WriteLine("В системе ещё не числятся сотрудники.");
                Console.WriteLine();
                Console.WriteLine("Продолжить...");
                Console.ReadKey();
                goto start;
            }
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            foreach (Worker w in list)
            {
                Console.WriteLine("[{0}] | Имя : {1} | Должность : {2} | Стаж : {3}", list.position, w.Name, w.Post, DateTime.Now.Year - w.EmploymentYear);
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.Write("Введите номер сотрудника, которого хотите удалить : ");
            int n = 0;

            try { n = Convert.ToInt32(Console.ReadLine()); }
            catch { goto InputError; }

            if (n > list.size)
                goto InputError;

            list.Delete(list[n]);
            Console.WriteLine("Сотрудник удалён из списка...");
            Console.WriteLine();
            Console.WriteLine("Продолжить...");
            Console.ReadKey();
            goto start;

            AddWorkerMenu:

            Console.ForegroundColor = ConsoleColor.White;

            string name;
            string post;
            int year;

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.Write("Имя сотрудника : ");
            name = Console.ReadLine();
            Console.Write("Должность сотрудника : ");
            post = Console.ReadLine();
            Console.Write("Год устройства сотрудника на работу : ");
            try { year = Convert.ToInt32(Console.ReadLine()); }
            catch { goto InputError; }

            try { list.Add(name, post, year); }
            catch (Exception e)
            {
                Console.SetCursorPosition(0, Console.CursorTop + 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('_', 30));
                Console.WriteLine(e.Message);
                Console.WriteLine(new string('_', 30));
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("Продолжить...");
                Console.ReadKey();
                goto start;
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("Сотрудник добавлен в список. Текущее количество сотрудников : {0}", list.size);
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("Продолжить...");
            Console.ReadKey();
            goto start;


            ShowWorkersMenu:

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("ПОЛНЫЙ СПИСОК СОТРУДНИКОВ");
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            foreach (Worker w in list)
            {
                Console.WriteLine("Имя : {0} | Должность : {1} | Год регистрации в системе : {2}", w.Name, w.Post, w.EmploymentYear);
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("...вывод завершён...");
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("Продолжить...");
            Console.ReadKey();
            goto start;


            ShowWorkersByLengthMenu:


            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            int min_year = 0;
            Console.Write("Введите минимальный стаж : ");
            try { min_year = Convert.ToInt32(Console.ReadLine()); }
            catch { goto InputError; }
            if (min_year < 0)
                goto InputError;

            Worker[] temp = list[(worker) => DateTime.Now.Year - worker.EmploymentYear >= min_year];

            if (temp.Length == 0)
            {
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine(new string('_', 30));
                Console.WriteLine("Работников со стажем больше или равным заданному не найдены");
                Console.WriteLine(new string('_', 30));
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("Продолжить...");
                Console.ReadKey();
                goto start;
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Список сотрудников со стажем равным или большим {0}", min_year);
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            foreach (Worker w in list)
            {
                if (DateTime.Now.Year - w.EmploymentYear >= min_year)
                    Console.WriteLine("Имя : {0} | Должность : {1} | Стаж : {2} | Год регистрации в системе : {3}", w.Name, w.Post,
                       DateTime.Now.Year - w.EmploymentYear, w.EmploymentYear);
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("...вывод завершён...");
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("Продолжить...");
            Console.ReadKey();
            goto start;


            InputError:
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Ввод не распознан");
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Продолжить...");
            Console.ReadKey();
            goto start;

        }
    }
}
