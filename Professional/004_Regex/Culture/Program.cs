using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Culture
{
    class Program
    {
        static string Check = @"A a - 3.12 грн
B b - 34.56 грн";

        static string[] GetSubstringWhithPatternt(string source,string pattern)
        {
            string[] result = new string[0];
            foreach (var item in Regex.Matches(source, pattern))
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = item.ToString();
            }
            return result;
        }

        static void Main(string[] args)
        {
            CultureInfo current_culture = CultureInfo.CurrentCulture;
            CultureInfo en_culture = new CultureInfo("en");
            string[] name = new string[0];
            float[] cost = new float[0];
            Console.WriteLine("Чек :");
            Console.WriteLine(Check);
            Console.WriteLine(new string('_',30));
            Console.WriteLine("Товары : ");
            foreach (var item in GetSubstringWhithPatternt(Check, @"[A-z]+\s[A-z]+"))
            {
                Console.WriteLine("Товар : {0}",item);
                Array.Resize(ref name, name.Length + 1);
                name[name.Length - 1] = item;
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Стоимость : ");
            foreach (var item in GetSubstringWhithPatternt(Check, @"\d+\.\d+"))
            {
                Console.WriteLine("Стоимость : {0}",item);
                Array.Resize(ref cost, cost.Length + 1);
                cost[cost.Length - 1] = Convert.ToSingle(Regex.Replace(item.ToString(),@"\.",","));
            }
            Console.WriteLine(new string('_', 30));
            float a = 3.14f;
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Вывод в формате текущей культуры : ");
            CultureInfo.CurrentCulture = current_culture;
            for (int i = 0; i < name.Length; i++)
            {
                    Console.WriteLine("Товар {0} стоит {1:d} грн", name[i], cost[i].ToString());
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Вывод в формате en - US культуры : ");
            CultureInfo.CurrentCulture = en_culture;
            for (int i = 0; i < name.Length; i++)
            {
                    Console.WriteLine("Товар {0} стоит {1:d} грн", name[i], cost[i].ToString());
            }
            Console.ReadKey();
        }
    }
}
