using System;

namespace FindAndReplaceManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Банун в холодильнике");
            Book.BookManager bm = new Book.BookManager();
            Book.Notes notes = new Book.Notes();

            bm.PrintText(book);

            notes.CreateNewNote(book, "В слове банан ошибка!");

            bm.FindAndReplace(book, "у", "а");

            notes.CreateNewNote(book, "Ошибка исправлена!");

            bm.PrintText(book);

            Console.WriteLine();

            Console.WriteLine("Заметки : ");

            Console.WriteLine();

            notes.PrintAllNotes(book);

            Console.WriteLine();

            Console.WriteLine("Существует ли заметка с индексом 3?");

            Console.WriteLine();

            notes.PrintNote(book,3);

            Console.ReadKey();
        }
    }
}
