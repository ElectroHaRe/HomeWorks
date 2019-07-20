namespace Collections
{
    using System.Collections;
    using System.Linq;
    using System;
    using System.Collections.Generic;

    public class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        T[] array = new T[0];

        public int size => array.Length;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                    return default(T);

                return array[index];
            }

            set
            {
                if (index >= 0 && index < size)
                    array[index] = value;
            }
        }

        public int this[T item]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (array[i].Equals(item))
                        return i;
                }
                return -1;
            }
        }

        public T[] this[Predicate<T> predicate]
        {
            get
            {
                T[] temp = new T[0];
                for (int i = 0; i < size; i++)
                {
                    if (predicate(array[i]))
                    {
                        Array.Resize(ref temp, temp.Length + 1);
                        temp[temp.Length - 1] = array[i];
                    }
                }
                return temp;
            }
        }

        public void Add(T item)
        {
            Array.Resize(ref array, size + 1);
            array[size - 1] = item;
        }

        public void Add(params T[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Add(items[i]);
            }
        }

        public bool Delete(T item)
        {
            if (!array.Contains(item))
                return false;

            T[] temp = new T[size - 1];
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

        public void ClearList()
        {
            array = new T[0];
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => this;

        IEnumerator IEnumerable.GetEnumerator() => this;

        public int position { get; private set; } = -1;

        object IEnumerator.Current => ((IEnumerator<T>)this).Current;

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
            if (position >= size - 1)
            {
                ((IEnumerator)this).Reset();
                return false;
            }
            else
            {
                position++;
                return true;
            }

        }

        void IEnumerator.Reset()
        {
            position = -1;
        }

        void IDisposable.Dispose()
        {
        }
    }
}
