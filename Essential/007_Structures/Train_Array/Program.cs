using System;

namespace Train_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] train = new Train[0];

            start:

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Записано поездов : {0}", train.Length);

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.WriteLine("1 - Добавить запись | 2 - Запросить информацию");

            switch (Console.ReadLine())
            {
                case "1":
                    goto AddTrain;
                case "2":
                    goto GetTrainInfo;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("_");
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.WriteLine("Ввод не распознан");
                    Console.WriteLine("_");
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    goto start;
            }

            AddTrain:


            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_");
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Array.Resize(ref train, train.Length + 1);

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Добавление записи о поезде в журнал.");

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Пункт назначения : ");
            Console.ForegroundColor = ConsoleColor.Gray;

            train[train.Length - 1].Destination = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Номер поезда : ");
            Console.ForegroundColor = ConsoleColor.Gray;

            train[train.Length - 1].Number = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Время отправления : ");
            Console.ForegroundColor = ConsoleColor.Gray;

            train[train.Length - 1].DepartureTime = Console.ReadLine();

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Запись добавлена...");

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_");
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            goto start;

            GetTrainInfo:

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_");
            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Запрос информации о поезде.");

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Введите номер поезда : ");
            Console.ForegroundColor = ConsoleColor.White;

            string number = Console.ReadLine();

            Train temp = new Train();

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            if (train.Length == 0)
                goto CantFind;

            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].Number == number)
                {
                    temp = train[i];
                }
                else if (i == train.Length - 1) {
                    goto CantFind;
                }
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            Console.WriteLine("Пункт назначения : {0}", temp.Destination);
            Console.WriteLine("Номер поезда : {0}", temp.Number);
            Console.WriteLine("Время отправления : {0}", temp.DepartureTime);

            Array.Resize(ref train, train.Length + 1);

            Console.Write("_", 30);

            Console.SetCursorPosition(0, Console.CursorTop + 2);

            goto start;

            CantFind:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Поезда с таким номером не существует!");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("_");
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            goto start;
        }
    }
}
