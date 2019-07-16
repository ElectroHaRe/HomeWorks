using System;

namespace _010_Collections
{

    static class ExpandingClass {

        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.GetSize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list[(uint)i];
            }
            return array;
        }
    }

    class Program
    {
        static MyList<string> list = new MyList<string>();


        static void AddElements(params string[] s) {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Добавление элемента {0} в коллекцию", s[i]);
                list.Add(s[i]);
            }
        }

        static void ShowAllElements()
        {
            Console.WriteLine("Вывод всех эелементов коллекции");
            Console.WriteLine();
            for (int i = 0; i < list.GetSize; i++)
            {
                Console.WriteLine("Элемент {0} : {1}", i, list[(uint)i]);
            }
        }

        static void Main()
        {
            string element = "MEH";

            AddElements("Meh", "Soska", "1", "YahOh");

            Console.WriteLine(new string('_',30));

            ShowAllElements();
            Console.WriteLine(new string('_', 30));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Для 3 задания, выведу все элементы листа");
            Console.WriteLine(new string('_', 30));
            Console.Write("лист содержит в себе массив элементов : ");
            for (int i = 0; i < list.GetSize; i++)
            {
                Console.Write(" {0} ,", list.GetArray()[i]);
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 30));
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            Console.ForegroundColor = ConsoleColor.Gray;

            for (; 0 < list.GetSize;)
            {
                Console.WriteLine("Колличество элементов коллекции : {0}", list.GetSize);
                Console.WriteLine(new string('_', 30));
                Console.WriteLine("Удаление элемента {0} из коллекции", list[(uint)list.GetSize - 1]);
                Console.WriteLine(new string('_', 30));
                list.Delete(list[(uint)list.GetSize-1]);
            }

            Console.WriteLine("Колличество элементов коллекции : {0}", list.GetSize);
            Console.WriteLine(new string('_', 30));
            Console.ReadKey();

        }
    }
}
