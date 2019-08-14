using System;
using System.Linq;
using System.Threading.Tasks;

namespace _014_TPL
{
    class Program
    {
        static byte[] byteArray = new byte[1000000];
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Создаём супер массив байтов, в котором 1 000 000 элементов!");
            Console.WriteLine(new string('_',30));
            Parallel.For(0, byteArray.Length, i => byteArray[i] = (byte)rand.Next(0, 255));
            Console.WriteLine("создание завершено...");
            Console.WriteLine(new string('_', 30));
            ParallelQuery<byte> oddArray = from x in byteArray.AsParallel()
                                           where x % 2 == 1 && x != 0
                                           select x;
            Console.WriteLine("PLINQ Запрос составлен. Выведем все нечётные числа");
            Parallel.ForEach(oddArray, x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine(new string('_',30));
            Console.ReadKey();
        }
    }
}
