using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntAndFloatCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, float> first = new Dictionary<int, float>();//Стандартный Generic словарь
            SortedList<int, float> second = new SortedList<int, float>();//Generic словарь с автоматической сортировкой по ключу

            first.Add(3, 0.152f);
            first.Add(1, 0.32f);
            second.Add(3, 0.152f);
            second.Add(1, 0.32f);

            Console.WriteLine("Сортируемая по времени добавления коллекция(словарь):");
            Console.WriteLine();
            foreach (var item in first)
            {
                Console.WriteLine(item.Key + " | " + item.Value);
            }
            Console.WriteLine(new string('_',30));
            Console.WriteLine("Автосортируемая по ключу коллекция(словарь):");
            Console.WriteLine();
            foreach (var item in second)
            {
                Console.WriteLine(item.Key + " | " + item.Value);
            }
            Console.WriteLine(new string('_', 30));
            Console.ReadKey();
        }
    }
}
