using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите что угодно чтобы создать 100 папок на диске B:");
            Console.ReadKey();
            Console.WriteLine("_");
            for (int i = 0; i < 100; i++)
            {
                Directory.CreateDirectory(@"B:\Folder_" + i.ToString()); 
            }
            Console.WriteLine("Для удаления этих папок нажмите опять же, что угодно");
            Console.ReadKey();
            Console.WriteLine("_");
            for (int i = 0; i < 100; i++)
            {
                Directory.Delete(@"B:\Folder_" + i.ToString());
            }
            Console.WriteLine("Всё это успешно завершено =)");
            Console.ReadKey();
        }
    }
}
