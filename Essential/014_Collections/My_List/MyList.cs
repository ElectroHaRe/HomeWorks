using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;

namespace My_List
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        T[] array = new T[0];

        public int size => array.Length;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                    return default(T);

                return array[index];
            }

            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
            }
        }

        public int this[T item]
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

        public void Add(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }

        public void Add(params T[] items)
        {
            Array.Resize(ref array, array.Length + items.Length);
            for (int i = items.Length; i > 0; i--)
            {
                array[array.Length - i] = items[items.Length - i];
            }
        }

        public bool Delete(T item)
        {
            if (!array.Contains(item))
                return false;

            T[] temp = new T[array.Length-1];
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

        public void Delete(params T[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Delete(items[i]);
            }
        }

        public void ClearSheet()
        {
            array = new T[0];
        }

        //Реализация интерфейса IEnumerable
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
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
                return ((IEnumerator<T>)this).Current;
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                if (position >= 0 && position < array.Length)
                    return array[position];
                else return default(T);
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
