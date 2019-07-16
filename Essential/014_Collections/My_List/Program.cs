using System;
using System.Collections.Generic;

namespace My_List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();
            Console.WriteLine("Добавим в лист числа: 1 , 5, 10, 2, 3, 6");
            numbers.Add(1, 5, 10, 2, 3, 6);
            Console.WriteLine("Вывод всех элементов коллекции с помощью foreach ( индекс | элемент) :");
            foreach (int number in numbers)
            {
                Console.WriteLine(" {0} | {1} ", numbers.position,number);
            }
            Console.WriteLine("Хмм, должно быть всё ок");
            Console.WriteLine("Ресетаем позицию");
            ((IEnumerator<int>)numbers).Reset();
            Console.WriteLine(new string('_',30));
            Console.WriteLine("Для последнего задания с расширяющим методом, выведу получившийся массив :");
            int[] temp = ((IEnumerable<int>)numbers).GetArray();
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine("Элемент {0} : {1}",i,temp[i]);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Элементов в коллекции : {0}",numbers.size);
            Console.WriteLine("Удаляю элементы 5,2,6 :");
            numbers.Delete(5, 2, 6);
            Console.WriteLine("Текущее количество элементов : {0}",numbers.size);
            Console.WriteLine("Повторный вывод элементов через foreach : ");
            foreach (int number in numbers)
            {
                Console.WriteLine(" {0} | {1} ", numbers.position, number);
            }
            Console.WriteLine("Удаление оставшихся элементов : ");
            numbers.ClearSheet();
            Console.WriteLine("Удаление завершено! Элементов в коллекции : {0}",numbers.size);
            Console.ReadKey();
        }
    }
}
