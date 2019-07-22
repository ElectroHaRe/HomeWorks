using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndCategoryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MagazineLog log = new MagazineLog();

            Customer c1 = new Customer("1", "_1_");
            Customer c2 = new Customer("2", "_2_");

            ProductCategory pc1 = new ProductCategory("pc1", 1);
            ProductCategory pc2 = new ProductCategory("pc2", 2);
            ProductCategory pc3 = new ProductCategory("pc3", 3);
            ProductCategory pc4 = new ProductCategory("pc4", 4);
            ProductCategory pc5 = new ProductCategory("pc5", 5);

            log.Add(c1, pc1); log.Add(c1, pc3); log.Add(c1, pc5);
            log.Add(c2, pc1); log.Add(c2, pc2); log.Add(c2, pc3); log.Add(c2, pc4); log.Add(c2, pc5);

            var group_log = from item in log
                            group item by item.Key;

            Console.WriteLine("Вывожу содержимое лога, сгруппированное по ключу");
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();

            foreach (var group_item in group_log)
            {
                Console.WriteLine("[ Покупатель {0} ]",group_item.Key);
                Console.WriteLine();
                foreach (var item in group_item)
                {
                    Console.WriteLine("Покупатель : {0} | товар : {1}", item.Key, item.Value);
                }
                Console.WriteLine(new string('_',30));
                Console.WriteLine();
            }

            Console.WriteLine("Удаляю товар [{0}] из лога для покупателя [{1}] и вывожу оставшиеся элементы по группам",pc5,c1);
            log.Remove(new KeyValuePair<Customer, ProductCategory>(c1, pc5));
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();

            foreach (var group_item in group_log)
            {
                Console.WriteLine("[ Покупатель {0} ]", group_item.Key);
                Console.WriteLine();
                foreach (var item in group_item)
                {
                    Console.WriteLine("Покупатель : {0} | товар : {1}", item.Key, item.Value);
                }
                Console.WriteLine(new string('_', 30));
                Console.WriteLine();
            }

            Console.WriteLine("Удаляю пары [ {0} | {1} ] и [ {2} | {3}] и расчитываю получить в выводе только одну группу!", c1,pc3,c1,pc1);
            log.Remove(new KeyValuePair<Customer, ProductCategory>(c1, pc3));
            //для проверки, не выдаст ли ошибку
            log.Remove(new KeyValuePair<Customer, ProductCategory>(c1, pc3));
            //
            log.Remove(new KeyValuePair<Customer, ProductCategory>(c1, pc1));
            //для проверки, не выдаст ли ошибку
            log.Remove(new KeyValuePair<Customer, ProductCategory>(c1, pc1));
            //
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();

            foreach (var group_item in group_log)
            {
                Console.WriteLine("[ Покупатель {0} ]", group_item.Key);
                Console.WriteLine();
                foreach (var item in group_item)
                {
                    Console.WriteLine("Покупатель : {0} | товар : {1}", item.Key, item.Value);
                }
                Console.WriteLine(new string('_', 30));
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
