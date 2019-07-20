using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizen
{
    class Program
    {
        static void Main(string[] args)
        {
            Pensioner p1 = new Pensioner("P1");
            Pensioner p2 = new Pensioner("P2");
            Student s1 = new Student("s1");
            Student s2 = new Student("s2");
            Worker w1 = new Worker("w1");
            CitizensCollection collection = new CitizensCollection();

            Console.WriteLine("добавляем элементы по очереди в порядке P1,W1,S2,P2,S1 и расчитываем что получится P1,P2,W1,S2,S1 :");
            Console.WriteLine();
            Console.WriteLine("Добавляем P1, он занимает позицию {0}",collection.Add(p1));
            Console.WriteLine("Добавляем W1, он занимает позицию {0}", collection.Add(w1));
            Console.WriteLine("Добавляем S2, он занимает позицию {0}", collection.Add(s2));
            Console.WriteLine("Добавляем P2, он занимает позицию {0}", collection.Add(p2));
            Console.WriteLine("Добавляем S1, он занимает позицию {0}", collection.Add(s1));

            Console.WriteLine(new string('_',30));

            Console.WriteLine("Вывод всех эелементов на эеран по порядку : ");
            Console.WriteLine();
            foreach (var item in collection)
            {
                Console.WriteLine("Гражданин с именем : {0}",item.Name);
            }
            Console.WriteLine(new string('_', 30));

            Console.WriteLine("Удалим W1 :");
            Console.WriteLine();
            collection.Delete(w1);
            foreach (var item in collection)
            {
                Console.WriteLine("Гражданин с именем : {0}", item.Name);
            }
            Console.WriteLine(new string('_', 30));

            
            Console.WriteLine("Попробуем добавить уже имеющийся элемент S2 и выведем все эелементы коллекции");
            Console.WriteLine();
            foreach (var item in collection)
            {
                Console.WriteLine("Гражданин с именем : {0}", item.Name);
            }
            Console.WriteLine(new string('_', 30));

            Console.WriteLine("Попробуем уджалить несуществующий элемент W1 и выведем всю коллекцию");
            Console.WriteLine();
            foreach (var item in collection)
            {
                Console.WriteLine("Гражданин с именем : {0}", item.Name);
            }
            Console.WriteLine(new string('_', 30));

            Student _s1 = new Student(s1.Name);
            int position1 = 0;
            int position2 = 0;
            int position3 = 0;
            collection.Contains(s1,out position1);
            collection.Contains(w1, out position2);
            Console.WriteLine("Чисто для теста, S1 стоит в очереди под номером {0}, а W1 стоит в очереди под номером {1}",position1,position2);
            Console.WriteLine(new string('_', 30));

            Console.WriteLine("Последний человек в очереди : {0}",collection.ReturnLast().Name);
            Console.WriteLine(new string('_', 30));

            Console.WriteLine("Удаляем первый элемент с именем {0} и выводим оставшиеся элементы",collection.DeleteFirst().Name);
            foreach (var item in collection)
            {
                Console.WriteLine("Гражданин с именем : {0}", item.Name);
            }
            Console.WriteLine(new string('_', 30));

            Console.WriteLine("Наконец, очищаем всю коллекцию!");

            collection.Clear();

            foreach (var item in collection)
            {
                Console.WriteLine("Гражданин с именем : {0}", item.Name);
            }
            Console.WriteLine(new string('_', 30));

            Console.WriteLine("Конец");

            Console.ReadKey();
        }
    }
}
