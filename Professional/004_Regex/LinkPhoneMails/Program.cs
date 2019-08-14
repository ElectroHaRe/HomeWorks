using System;

namespace LinkPhoneMails
{
    class Program
    {
        static string source = "Test1@mail.ru" +
                                "+7-123-456:12 21" +
                                "a;ldfm" +
                                "+12345644239" +
                                "sdfogl " +
                                "Test_2@gmail.com " + "mictosoft.com/ " +
            "https://www.google.ru/search?client=opera&q=%D1%80%D0%B5%D0%B3%D1%83%D0%BB%D1%8F%D1%80%D0%BD%D1%8B%D0%B5+%D0%B2%D1%8B%D1%80%D0%B0%D0%B6%D0%B5%D0%BD%D0%B8%D1%8F+c%23&sourceid=opera&ie=UTF-8&oe=UTF-8";

        static void Main(string[] args)
        {
            Console.WriteLine("Все электронные почты в строке:\n");
            string[] result = TextWorker.GetMails(source);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВсе номера сотовых телефонов в строке:\n");
            result = TextWorker.GetPhoneNumbers(source);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nВсе ссылки на сайты в строке:\n");
            result = TextWorker.GetLinks(source);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
