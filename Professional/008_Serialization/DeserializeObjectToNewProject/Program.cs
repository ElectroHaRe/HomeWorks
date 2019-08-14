using System;
using System.IO;
using System.Xml.Serialization;
using _008_Serialization;

namespace DeserializeObjectToNewProject
{
    class Program
    {
        static string fileName1 = "XMLSerializationTest.xml";
        static string fileName2 = "XMLSerializationTest_Attributes.xml";

        static void Main(string[] args)
        {
            ClassForXMLSerialization test1 = new ClassForXMLSerialization();
            ClassForXMLSerialization2 test2 = new ClassForXMLSerialization2();
            test1.ResetFields();test2.ResetFields();
            Console.WriteLine("Инициализировали объекты и сбросили значения их полей");
            Console.WriteLine();
            Console.WriteLine("Состояние объекта 1 :");
            Console.WriteLine(test1);
            Console.WriteLine("Состояние объекта 2 :");
            Console.WriteLine(test2);
            Console.WriteLine(new string('_',30));
            Console.WriteLine();
            XmlSerializer serializer = new XmlSerializer(test1.GetType());
            using (FileStream fs = new FileStream(fileName1, FileMode.Open))
            {
                test1 = serializer.Deserialize(fs) as ClassForXMLSerialization;
            }
            serializer = new XmlSerializer(test2.GetType());
            using (FileStream fs = new FileStream(fileName2, FileMode.Open))
            {
                test2 = serializer.Deserialize(fs) as ClassForXMLSerialization2;
            }
            Console.WriteLine("Десериализовали объекты");
            Console.WriteLine();
            Console.WriteLine("Состояние объекта 1 : ");
            Console.WriteLine(test1);
            Console.WriteLine("Состояние объекта 2 : ");
            Console.WriteLine(test2);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();
            Console.WriteLine("Межпроцессная десериализация завершена");
            Console.ReadKey();
        }
    }
}
