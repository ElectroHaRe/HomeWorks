using System;
using System.Text.RegularExpressions;


namespace decoder
{
    class Program
    {
        static string source = "Я сидел на диване - диван сидел на мне...";

        static string ReplaceAll(string word,string source)
        {
            return Regex.Replace(source.ToLowerInvariant(), @"(" + word + ")", "ГАВ!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Исходная трока : {0}",source);
            Console.WriteLine("Вместо предлогов НА подставим ГАВ! : {0}", ReplaceAll("на", source));
            Console.ReadKey();
        }
    }
}
