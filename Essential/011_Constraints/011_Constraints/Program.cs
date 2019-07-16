using System;

namespace _011_Constraints
{
    class Program
    {
        static CarCollection<Porsche> PorscheCollection = new CarCollection<Porsche>();

        static Porsche Porche916 = new Porsche("Porsche 916", 1971);
        static Porsche Porsche911 = new Porsche("Porsche 911", 1966);
        static Porsche Porsche991 = new Porsche("Porsche 911(991)", 2011);


        static void Main(string[] args)
        {
            Console.WriteLine("Добавление порше в коллекцию");
            Console.WriteLine(new string('_',30));
            PorscheCollection.Add(Porsche991);
            Console.WriteLine("{0} {1} года выпуска добавлен в коллекцию",PorscheCollection[PorscheCollection.Size-1].Name, PorscheCollection[PorscheCollection.Size - 1].Year);
            PorscheCollection.Add(Porsche911);
            Console.WriteLine("{0} {1} года выпуска добавлен в коллекцию", PorscheCollection[PorscheCollection.Size - 1].Name, PorscheCollection[PorscheCollection.Size - 1].Year);
            PorscheCollection.Add(Porche916);
            Console.WriteLine("{0} {1} года выпуска добавлен в коллекцию", PorscheCollection[PorscheCollection.Size - 1].Name, PorscheCollection[PorscheCollection.Size - 1].Year);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Машин в коллекции : {0}",PorscheCollection.Size);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Сортировка по году выпуска и последовательный вывод элементов");
            Console.WriteLine(new string('_', 30));
            PorscheCollection.SortByYear();
            for (int i = 0; i < PorscheCollection.Size; i++)
            {
                Console.WriteLine("{0} {1} года выпуска | идекс {2}",PorscheCollection[i].Name,PorscheCollection[PorscheCollection[i].Name][0].Year, 
                   PorscheCollection[PorscheCollection[PorscheCollection[i].Year][0]]);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Также была проведена проверка всех индексаторов");
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Удаления автомобилей из коллекции");
            Console.WriteLine(new string('_', 30));
            for (; 0<PorscheCollection.Size ; )
            {
                Porsche temp = PorscheCollection[PorscheCollection.Size - 1];
                Console.WriteLine("Удаление {0} {1} года выпуска под индексом {2} из коллекции", temp.Name,temp.Year,PorscheCollection[temp]);
                PorscheCollection.Delete(temp);
            }
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Машин в коллекции : {0}",PorscheCollection.Size);
            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Задание выполнено");
            Console.WriteLine(new string('_', 30));

            Console.ReadKey();
        }
    }
}
