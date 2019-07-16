using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;

namespace _15_Exceptions
{
    class WorkerList : IEnumerable<Worker>, IEnumerator<Worker>
    {
        Worker[] array = new Worker[0];

        public int size => array.Length;

        public Worker this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                    return default(Worker);

                return array[index];
            }

            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
            }
        }

        public int this[Worker item]
        {
            get
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Equals(item))
                        return i;
                }
                return -1;
            }
        }

        public Worker[] this[string name]
        {
            get
            {
                Worker[] temp = new Worker[0];
                for (int i = 0; i < size; i++)
                {
                    if (array[i].Name == name)
                    {
                        Array.Resize(ref temp, temp.Length);
                        temp[temp.Length - 1] = array[i];
                    }
                }
                return temp;
            }
        }

        public Worker[] this[string name,string post]
        {
            get
            {
                Worker[] temp = new Worker[0];
                for (int i = 0; i < size; i++)
                {
                    if (array[i].Name == name && array[i].Post == post)
                    {
                        Array.Resize(ref temp, temp.Length);
                        temp[temp.Length - 1] = array[i];
                    }
                }
                return temp;
            }
        }

        public Worker[] this[string name, string post, int employment_year]
        {
            get
            {
                Worker[] temp = new Worker[0];
                for (int i = 0; i < size; i++)
                {
                    if (array[i].Name == name && array[i].Post == post && array[i].EmploymentYear == employment_year)
                    {
                        Array.Resize(ref temp, temp.Length);
                        temp[temp.Length - 1] = array[i];
                    }
                }
                return temp;
            }
        }

        public Worker[] this[Predicate<Worker> filtr]
        {
            get
            {
                Worker[] temp = new Worker[0];
                for (int i = 0; i < size; i++)
                {
                    if (filtr(array[i]))
                    {
                        Array.Resize(ref temp, temp.Length + 1);
                        temp[temp.Length - 1] = array[i];
                    }
                }
                return temp;
            }
        }

        public Worker[] GetWorkersByYear(int employment_year)
        {
            return this[(worker) => worker.EmploymentYear == employment_year];
        }

        public Worker[] GetWorkersByPost(string post)
        {
            return this[(Worker) => Worker.Post == post];
        }

        public void Add(Worker item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }

        public void Add(params Worker[] items)
        {
            Array.Resize(ref array, array.Length + items.Length);
            for (int i = items.Length; i > 0; i--)
            {
                array[array.Length - i] = items[items.Length - i];
            }
        }

        public void Add(string name, string post, int employment_year)
        {
            Worker temp = new Worker(name, post, employment_year);
            Add(temp);
        }

        public bool Delete(Worker item)
        {
            if (!array.Contains(item))
                return false;

            Worker[] temp = new Worker[array.Length - 1];
            int j = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (array[i].Equals(item))
                    j = 1;
                temp[i] = array[i + j];
            }

            array = temp;
            return true;
        }

        public void Delete(params Worker[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Delete(items[i]);
            }
        }

        public void ClearSheet()
        {
            array = new Worker[0];
        }

        //Реализация интерфейса IEnumerable
        IEnumerator<Worker> IEnumerable<Worker>.GetEnumerator()
        {
            return this;
        }
        //

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        //Реализация интерфейса Ienumerator
        public int position { get; private set; } = -1;

        object IEnumerator.Current
        {
            get
            {
                return ((IEnumerator<Worker>)this).Current;
            }
        }

        Worker IEnumerator<Worker>.Current
        {
            get
            {
                if (position >= 0 && position < array.Length)
                    return array[position];
                else return default(Worker);
            }
        }

        bool IEnumerator.MoveNext()
        {
            if (position >= array.Length - 1)
                return false;
            else position++;

            return true;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }

        void IDisposable.Dispose()
        {
        }
        //
    }
}
