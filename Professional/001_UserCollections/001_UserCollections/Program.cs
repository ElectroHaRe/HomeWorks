using System;
using System.Collections;

namespace _001_UserCollections
{
    class Program
    {
        static IEnumerable GetCollectionOf(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] % 2 != 0 && items[i]!=0)
                    yield return Math.Pow(items[i], 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Квадраты нечётных чисел среди последовательности {1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10} : ");

            foreach (var item in GetCollectionOf(0,1, 2, 3, 4, 5,6,7,8,9,10))
            {
                Console.Write(item + " , ");
            }

            Console.ReadKey();
        }
    }
}
