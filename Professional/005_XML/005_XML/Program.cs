using System;
using System.Xml;

namespace _005_XML
{
    class Program
    {
        static string doc_name = "TelephoneBook.xml";

        static void Main(string[] args)
        {
            #region Вывод инфы из документа
            XmlDocument document = new XmlDocument();
            document.Load(doc_name);
            XmlNode root = document.DocumentElement;//root of the XMLDocument
            Console.WriteLine("Вывод инфы из документа : ");
            Console.SetCursorPosition(0,Console.CursorTop + 1);
            foreach (XmlNode node in root.ChildNodes)
            {
                Console.WriteLine("Корень : {0} | Ветвь : {1} | Номер телефона : {2} | Имя : {3}",
                root.Name, node.Name, node.Attributes["TelephoneNumber"].InnerText, node.InnerText);
            }
            #endregion

            Console.WriteLine(new string('_',30));

            #region Вывод номеров телефонов
            Console.WriteLine("Вывод только номеров телефонов:");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            foreach (XmlNode node in root)
            {
                Console.WriteLine(node.Attributes["TelephoneNumber"].InnerText);
            }
            #endregion

            Console.WriteLine(new string('_', 30));

            Console.ReadKey();
        }
    }
}
