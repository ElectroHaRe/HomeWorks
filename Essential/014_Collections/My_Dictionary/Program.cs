using System;

namespace My_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добавляю в словарь записи : 1 - A, 2 - B, 3 - C, 4 - D");
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>(1,"A");
            dictionary.Add(2, "B");
            dictionary.Add(3, "C");
            dictionary.Add(4, "D");
            Console.WriteLine("Количество элементов : {0}", dictionary.size);
            Console.WriteLine("Вывод элементов словаря с помощью foreach : ");
            foreach (int key in dictionary)
            {
                Console.WriteLine(" position {0} : {1} - {2} ",dictionary.position, key,dictionary[key]);
            }
            Console.WriteLine("Удаление двух центральных элементов : ");
            dictionary.Delete(2, 3);
            Console.WriteLine("Вывод всех элементов через foreach : ");
            foreach (int key in dictionary)
            {
                Console.WriteLine(" {0} - {1} ", key, dictionary[key]);
            }
            Console.WriteLine("Текущее количество элементов : {0}",dictionary.size);
            Console.WriteLine("Удаление всех эелементов : ");
            dictionary.Delete(56);
            dictionary.ClearDictionary();
            Console.WriteLine("Size = {0}",dictionary.size);

            Console.ReadKey();
        }
    }
}
