using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            Article article;
            Store store = new Store();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Введите наименование товара или его индекс в системе : ");

            string indexOrName = Console.ReadLine();

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            try {
                article = store[Convert.ToInt32(indexOrName)];
                Console.WriteLine("Вы выбрали поиск товара по индексу");
            }
            catch
            {
                article = store[indexOrName];
                Console.WriteLine("Вы выбрали поиск товара по имени");
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);

            if (article == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Товар не найден");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("_",30);
                Console.SetCursorPosition(0, Console.CursorTop + 1);
                Console.WriteLine("1 - Repeat | 2 - Exit");
                switch (Console.ReadLine()) {
                    case "1":
                        Console.SetCursorPosition(0, Console.CursorTop + 1);
                        Console.WriteLine("_", 30);
                        Console.SetCursorPosition(0, Console.CursorTop + 1);
                        goto start;
                    default:
                        break;
                }
            }
            else {
                Console.WriteLine("Наименование товара : {0}",article.name);
                Console.WriteLine("Магазин, в котором содержится товар : {0}",article.shop);
                Console.WriteLine("Цена товара в гривнах : {0}",article.cost);
            }

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("_", 30);
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("1 - Repeat | 2 - Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    Console.WriteLine("_", 30);
                    Console.SetCursorPosition(0, Console.CursorTop + 1);
                    goto start;
                default:
                    break;
            }
        }
    }
}
