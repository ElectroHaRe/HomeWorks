using System;
using System.IO;
using System.Text;

namespace CreateAndReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"B:\soska.txt";

            Console.WriteLine("Создание и перезаписаь файла по пути {0}. А вот что в нём записано : ",path);
            using (StreamWriter writer = new StreamWriter(path,false,Encoding.Default))//append (true - добавление данных в файл, false - перезапись файла)
            {
                writer.WriteLine("Ммммм, сладенько и успокаивающе)");
            }

            using (StreamReader reader = new StreamReader(path,Encoding.Default))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

            DirectoryInfo d_info = new DirectoryInfo(@"B:\");

            //Console.WriteLine("Найду ли я этот файл?)");
            //Console.WriteLine(d_info.GetFileSystemInfos("soska.*").Length);

            Console.ReadLine();
        }
    }
}
