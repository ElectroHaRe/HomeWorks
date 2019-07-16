using System;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meg = new int[20];
            Random rand = new Random();


            for (int i = 0; i < meg.Length; i++)
            {
                meg[i] = rand.Next(-100, 100);
            }

            Console.WriteLine("Исходный массив : ");
            for (int i = 0; i < meg.Length; i++)
            {
                if (i < meg.Length - 1)
                    Console.Write(meg[i] + " , ");
                else Console.Write(meg[i] + " ;");
            }
            Console.WriteLine();
            Console.WriteLine();

            meg.SortAscending();

            Console.WriteLine("Отсортированный массив : ");
            for (int i = 0; i < meg.Length; i++)
            {
                if (i < meg.Length - 1)
                    Console.Write(meg[i] + " , ");
                else Console.Write(meg[i] + " ;");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
