using System;

namespace FindAndReplaceManager
{
    class Book
    {
        public Book(string text)
        {
            this.text = text;
        }

        private string text;

        private string[] notes = new string[0];

        public class BookManager
        {

            //Возвращает -1 если запроса нет в источнике
            private int GetRequestPosition(string source ,string request) {
                string temp = "";
                for (int i = 0; i < source.Length; i++)
                {
                    temp += source[i];
                    if (temp.Contains(request))
                    {
                        return i - request.Length + 1;
                    }
                }
                return -1;
            }

            //0 - замещение прошло успешно, 1 - запрос не найден в тексте книги
            public int FindAndReplace(Book book,string request,string replace)
            {
                int pos = GetRequestPosition(book.text, request);

                if (pos < 0)
                    return 1;

                string temp = "";

                for (int i = 0; i < book.text.Length - request.Length + replace.Length; i++)
                {
                    temp += i < pos ? book.text[i] : i < pos + replace.Length ? replace[i - pos] : book.text[i + request.Length - replace.Length];
                }

                book.text = temp;

                return 0;
            }

            public void PrintText(Book book) {
                Console.WriteLine(book.text);
            }

            public string GetText(Book book) {
                return book.text;
            }
        }

        public class Notes
        {
            public void CreateNewNote(Book book, string note_text) {
                Array.Resize(ref book.notes, book.notes.Length + 1);
                book.notes[book.notes.Length - 1] = note_text;
            }

            public void PrintNote(Book book,int note_number) {
                try
                {
                    Console.WriteLine(book.notes[note_number]);
                }
                catch {
                    Console.WriteLine("Заметка с индексом {0} ещё не создана",note_number);
                }
            }

            public void PrintAllNotes(Book book) {
                if (book.notes.Length < 1)
                {
                    Console.WriteLine("Заметки ещё не созданы в данной книге");
                    return;
                }
                for (int i = 0; i < book.notes.Length; i++)
                {
                    Console.WriteLine("Заметка {0} : {1}",i,book.notes[i]);
                }
            }
        }
    }
}
