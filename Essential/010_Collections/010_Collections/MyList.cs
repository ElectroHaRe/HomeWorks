using System;

namespace _010_Collections
{
    class MyList<T> //where T: new()
    {
        private T[] array = new T[0];

        public T this[uint index]
        {
            get
            {
                if (index < array.Length)
                {
                    return array[index];
                }
                else return default(T);
            }

            set
            {
                if (index < array.Length)
                {
                    array[index] = value;
                }
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
            private set
            {
                int index = this[item];
                if (index >= 0) {
                    array[index] = item; 
                }
            }
        }

        public int GetSize => array.Length;

        public void Add(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
        }

        public void Add(params T[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = items[i];
            }
        }

        private int Delete(uint index) {
            if (index < array.Length)
            {
                T[] temp = new T[array.Length - 1];

                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = i < index ? array[i] : array[i + 1];
                }

                array = temp;

                return 0;
            }
            return 1;
        }

        public void Delete(T item) {
            int index = this[item];
            Delete((uint)index);
        }
    }
}
