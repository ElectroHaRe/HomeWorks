using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthCollection collection = new MonthCollection();

            Console.WriteLine("Месяцы в 2019 году : ");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('_',30));
            Console.WriteLine("Третий месяц в году : {0}",collection[3].Name);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("В декабре {0} день", collection.GetDaysByMonth("December"));
            Console.WriteLine(new string('_', 30));
            Console.ReadKey();
        }
    }
}
