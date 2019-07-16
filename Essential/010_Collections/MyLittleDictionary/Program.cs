using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleDictionary
{
    class Program
    {
        static MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Добавление элементов");
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("< 1 | A >");
            dictionary.Add(1, "A");
            Console.WriteLine("< 2 | B >");
            dictionary.Add(2, "B");
            Console.WriteLine("< 3 | C >");
            dictionary.Add(3, "C");
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Размер получившегося dictionary : {0}", dictionary.GetSize);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Вывод элементов по ключу");
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("{0} - {1}", 1, dictionary[1]);
            Console.WriteLine("{0} - {1}", 2, dictionary[2]);
            Console.WriteLine("{0} - {1}", 3, dictionary[3]);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Текущий размер : {0}",dictionary.GetSize);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Удаление элемента с ключом {0}",2);
            dictionary.Delete(2);
            Console.WriteLine("Вывод элементов по ключу");
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("{0} - {1}", 1, dictionary[1]);
            Console.WriteLine("{0} - {1}", 2, dictionary[2]);
            Console.WriteLine("{0} - {1}", 3, dictionary[3]);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Попытка удалить несуществующий элемент");
            dictionary.Delete(2);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Текущий размер : {0}", dictionary.GetSize);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Удаление оставшихся элементов");
            dictionary.Delete(1);
            dictionary.Delete(3);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Текущий размер : {0}", dictionary.GetSize);
            Console.WriteLine(new string('_', 30));
            Console.ReadKey();
        }
    }
}
