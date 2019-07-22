using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndCategoryCollection_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("c1", "_1_");
            Customer c2 = new Customer("c2", "_2_");

            ProductCategory pc1 = new ProductCategory("pc1", 0);
            ProductCategory pc2 = new ProductCategory("pc2", 1);
            ProductCategory pc3 = new ProductCategory("pc3", 2);
            ProductCategory pc4 = new ProductCategory("pc4", 3);
            ProductCategory pc5 = new ProductCategory("pc5", 4);

            MagazineLog log = new MagazineLog(new KeyValuePair<Customer, ProductCategory>(c1, pc1));
            log.Add(c1, pc2);
            log.Add(c2, pc3);
            log.Add(c2, pc4);
            log.Add(c1, pc5);
            log.Add(c2, pc1);

            Console.WriteLine("Выводим все элементы дога на экран");
            Console.WriteLine(new string('_',30));
            foreach (var item in log)
            {
                Console.WriteLine("Покупатель : {0} | Категория товара : {1}",item.Key,item.Value);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();
            Console.WriteLine("Получаем все категории товаров приобретённых покупателем [{0}]",c2);
            foreach (var item in log.GetCategoriesByCustomer(c2))
            {
                Console.WriteLine("Категория товара: {0}",item);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();
            Console.WriteLine("Получаем всех покупателей товаров категории [{0}]",pc1);
            foreach (var item in log.GetCustomersByProductCategory(pc1))
            {
                Console.WriteLine("Покупатель : {0}", item);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();
            Console.WriteLine("Удаление категорий товаров из лога покупателя {0}",c2);
            log.Remove(c2, pc1);
            log.Remove(c2, pc2);
            log.Remove(c2, pc3);
            log.Remove(c2, pc4);
            log.Remove(c2, pc5);
            Console.WriteLine();
            Console.WriteLine("Вывод оставшихся элементов лога");
            Console.WriteLine();
            foreach (var item in log)
            {
                Console.WriteLine("Покупатель : {0} | Товар : {1}",item.Key,item.Value);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();
            Console.WriteLine("Удаление ключа в одну операцию и вывод оставшихся элементов (должен вывести ничего)");
            Console.WriteLine();
            log.Remove(c1);
            log.Remove(c2);
            foreach (var item in log)
            {
                Console.WriteLine("Покупатель : {0} | Товар : {1}", item.Key, item.Value);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();
            Console.WriteLine("Всё сработало)");

            Console.ReadKey();
        }
    }
}
