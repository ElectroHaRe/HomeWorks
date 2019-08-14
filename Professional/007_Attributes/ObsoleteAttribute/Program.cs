using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsoleteAttribute
{
    class Program
    {
        [System.Obsolete("Тестовый метод устарел. Его использование может привести к уажасающим последствиям!")]
        static void testMethodWithoutError() { }

        [System.Obsolete("Тестовый метод безнадёжно устарел. Его использование недопустимо!", true)]
        static void testMethodWithError() { }

        static void Main(string[] args)
        {
            testMethodWithoutError();
           // testMethodWithError();
            Console.ReadKey();
        }
    }
}
