using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassMyStruct
{
    class Program
    {
        static void MyClassChanger(MyClass myClass) {
            myClass.change = "Изменено";
        }

        static void MyStructChanger(MyStruct myStruct) {
            myStruct.change = "Изменено";
        }

        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct { change = "не изменено" };
            MyClass myClass = new MyClass("не изменено");

            Console.WriteLine("До метода: Класс - {0} | Структура - {1}",myClass.change,myStruct.change);

            MyClassChanger(myClass);
            MyStructChanger(myStruct);

            Console.WriteLine("После метода: Класс - {0} | Структура - {1}", myClass.change, myStruct.change);

            Console.ReadKey();
        }
    }
}
