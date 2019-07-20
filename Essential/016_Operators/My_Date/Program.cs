using System;

namespace My_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(17, 07, 2019);
            Date d2 = new Date(-15, 1, 2020);
            Console.WriteLine("[1] " + d1);
            Console.WriteLine("[2] " + d2);
            Console.WriteLine("d1 + 30 = {0}", d1 + 30);
            Console.WriteLine("d1 - 11 = {0}", d1 - 11);
            Console.WriteLine("d2 - d1 = {0}", d2 - d1);
            Console.WriteLine("d2 + d1 = {0}", d2 + d1);
            Console.ReadKey();
        }
    }
}
