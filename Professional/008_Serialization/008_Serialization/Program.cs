using System;
using System.IO;
using System.Xml.Serialization;

namespace _008_Serialization
{
    //Для сериализации в XML формате не обязательно ставить аттрибут Serializable
    class Program
    {
        static string fileName1 = "XMLSerializationTest.xml";
        static string fileName2 = "XMLSerializationTest_Attributes.xml";

        static void Main(string[] args)
        {
            #region XML Сериализация полей в виде ветвей
            ClassForXMLSerialization test = new ClassForXMLSerialization();
            XmlSerializer serializer = new XmlSerializer(test.GetType());
            Console.WriteLine("XML Сериализация полей в виде ветвей");
            Console.WriteLine();
            Console.WriteLine("Текущее состояние объекта :\n {0} | Хэш код : {1}", test, test.GetHashCode());

            using (StreamWriter writer = new StreamWriter(File.Open(fileName1, FileMode.OpenOrCreate)))
            {
                serializer.Serialize(writer, test);
            }

            test.ResetFields();
            Console.WriteLine("Сериализовали, а за тем ресетнули поля. Получили вот такое состояние объекта :\n {0} | Хэш код : {1}", test, test.GetHashCode());
            Console.WriteLine();

            using (StreamReader reader = new StreamReader(File.OpenRead(fileName1)))
            {
                test = serializer.Deserialize(reader) as ClassForXMLSerialization;
            }

            Console.WriteLine("Восстановили объект! Его текущее состояние : {0} | Хэш код : {1}", test, test.GetHashCode());
            Console.WriteLine(new string('_', 30));
            #endregion

            #region XML Сериализация полей в виде аттрибутов
            Console.WriteLine();
            Console.WriteLine("XML Сериализация полей в виде аттрибутов");
            Console.WriteLine();
            ClassForXMLSerialization2 test1 = new ClassForXMLSerialization2();
            Console.WriteLine("Текущее состояние объекта :\n {0} | Хэш код : {1}", test1, test1.GetHashCode());

            serializer = new XmlSerializer(test1.GetType());

            using (FileStream fs = new FileStream(fileName2, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, test1);
            }

            test1.ResetFields();
            Console.WriteLine("Сериализовали, а за тем ресетнули поля. Получили вот такое состояние объекта :\n {0} | Хэш код : {1}", test1, test1.GetHashCode());
            Console.WriteLine();

            using (FileStream fs = new FileStream(fileName2, FileMode.OpenOrCreate))
            {
                test1 = serializer.Deserialize(fs) as ClassForXMLSerialization2;
            }

            Console.WriteLine("Восстановили объект! Его текущее состояние : {0} | Хэш код : {1}", test1, test1.GetHashCode());
            Console.WriteLine(new string('_', 30));
            #endregion

            Console.ReadLine();
        }
    }
}
