using System;

namespace MyDictionary
{
    class Program
    {
        static MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Добавление записей в блокнот. Формат записи : Ключ | Запись ");
            Console.WriteLine(new string('_',30));
            Console.WriteLine(" {0} | {1} ", 1, "A");
            dictionary[1] = "A";
            Console.WriteLine(" {0} | {1} ", 2, "B");
            dictionary.Add(2, "B");
            Console.WriteLine(" {0} | {1} ", 3, "C");
            dictionary.Add(3, "C");
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Изменение записи {0} по ключу {1} на Ф_Ф",dictionary[2],2);
            dictionary[2] = "Ф_Ф";
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Вывод всех элементов на экран");
            Console.WriteLine(new string('_', 30));
            for (int i = 0; i < dictionary.size; i++)
            {
                Console.WriteLine(" {0} | {1}",dictionary.GetKeyList[i],dictionary.GetValueList[i]);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Поочерёдное удаление элементов");
            Console.WriteLine(new string('_', 30));
            for (; 1 < dictionary.size;)
            {
                Console.WriteLine("Удаление : {0} | {1}",dictionary.GetKeyList[dictionary.size-1], dictionary.GetValueList[dictionary.size - 1]);
                dictionary.Delete(dictionary.GetKeyList[dictionary.size - 1]);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Вывод всех элементов на экран");
            Console.WriteLine(new string('_', 30));
            for (int i = 0; i < dictionary.size; i++)
            {
                Console.WriteLine(" {0} | {1}", dictionary.GetKeyList[i], dictionary.GetValueList[i]);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Удаление последнего элемента");
            Console.WriteLine(new string('_', 30));
            for (; 0 < dictionary.size;)
            {
                Console.WriteLine("Удаление : {0} | {1}", dictionary.GetKeyList[dictionary.size - 1], dictionary.GetValueList[dictionary.size - 1]);
                dictionary.Delete(dictionary.GetKeyList[dictionary.size - 1]);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Осталось элементов : {0}",dictionary.size);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Задание полностью выполнено!");
            Console.WriteLine(new string('_', 30));

            Console.ReadKey();
        }
    }
}
