using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Type[] types = typeof(Program).Assembly.GetTypes();
            Console.WriteLine("Все типы сборки : ");
            Console.WriteLine();
            foreach (Type type in types)
            {
                Console.WriteLine("Имя типа : {0}", type.Name);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Все типы сборки с атрибутом AccessLevel : ");
            Console.WriteLine();
            foreach (Type type in types)
            {
                if (type.GetCustomAttribute<AccessLevelAttribute>() != null)
                    Console.WriteLine("Тип {0} имеет уровень доступа [{1}]",type.Name, type.GetCustomAttribute<AccessLevelAttribute>().Level);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Конец доп задания!");
            Console.ReadKey();
        }
    }
}
