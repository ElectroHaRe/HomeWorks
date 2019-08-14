using System;

namespace _009_GarbageCollector
{
    class MyDisposableClass : IDisposable
    {
        public byte[] BigArray { get; private set; } = new byte[1024 * 1024 * 500];

        private bool dispose = false;

        void IDisposable.Dispose()
        {
            CleanUp(true);
        }

        private void CleanUp(bool disposing)
        {
            if (!this.dispose)
            {
                Console.WriteLine(new string('_', 30));
                if (disposing)
                {
                    BigArray = new byte[0];
                    Console.WriteLine("Я очистил все свои Управляемые ресурсы");
                }
                dispose = true;
                GC.SuppressFinalize(this);
                Console.WriteLine("Я очистил все свои НЕуправляемые ресурсы");
                Console.WriteLine(new string('_', 30));
                Console.WriteLine();
            }
        }

        ~MyDisposableClass()
        {
            CleanUp(false);
        }
    }

    //Просто чтобы было)
    class DefaultDisposePattern : IDisposable
    {
        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~DefaultDisposePattern() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        void IDisposable.Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {

            using (MyDisposableClass mdc = new MyDisposableClass())
            {
                Console.WriteLine("Мой большущий объект построен! Его поколение {0}. В данный момент заполнено {1} Мб памяти!",
                    GC.GetGeneration(mdc), GC.GetTotalMemory(false) / (1024 * 1024));
                Console.WriteLine("(Поколение нулевое потому, что наш объект является обёрктой для по настоящему большого объекта=))");
                Console.WriteLine("По настоящему большой объект, ссылка на который хранится в ранее созданном, имеет поколение : {0}.",
    GC.GetGeneration(mdc.BigArray));
            }
            Console.WriteLine("Теперь память немного подчищена(по идее).В данный момент заполнено {0} Мб памяти!", GC.GetTotalMemory(false) / (1024 * 1024));
            Console.ReadKey();
        }
    }
}
