using System;
using System.Collections.Generic;
using System.Linq;

namespace _002_SystemCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> sortedList = new SortedList<string, string>();
            sortedList["A"] = "a"; sortedList["B"] = "b"; sortedList["C"] = "c"; sortedList["D"] = "d";
            Console.WriteLine("Вывод пары ( ключ | значение ) в алфавитном порядке");
            foreach (var item in sortedList)
            {
                Console.WriteLine(" {0} | {1} ", item.Key, item.Value);
            }
            Console.WriteLine("Вывод пары ( ключ | значение ) в обратном алфавитном порядке");
            foreach (var item in  sortedList.OrderByDescending(item => item.Value))
            {
                Console.WriteLine(" {0} | {1} ", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
