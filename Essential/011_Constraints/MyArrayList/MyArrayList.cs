using System;
using System.Linq;

namespace MyArrayList
{
    class MyArrayList
    {
        object[] collection = new object[0];

        public object this[int index]
        {
            get
            {
                if (index < 0 || index >= collection.Length)
                    return null;
                else return collection[index];
            }
            set
            {
                if (index > 0 && index < collection.Length)
                    collection[index] = value;
            }
        }

        public int this[object item]
        {
            get
            {
                if (!collection.Contains(item))
                    return -1;

                for (int i = 0; i < collection.Length; i++)
                {
                    if (collection[i].Equals(item))
                        return i;
                }
                return -1;
            }
        }

        public int this[object item,int start, int end]
        {
            get
            {
                if (start < 0 || end < 0)
                    return -1;
                if (start > collection.Length || end > collection.Length)
                    return -1;
                if (start > end)
                    return -1;
                for (int i = start; i < end; i++)
                {
                    if (collection[i].Equals(item))
                        return i;
                }
                return -1;
            }
        }

        public void Add(object item) {
            Array.Resize(ref collection, collection.Length + 1);
            collection[collection.Length - 1] = item;
        }

        public int Delete(object item)
        {
            if (!collection.Contains(item))
                return 1;

            object[] temp = new object[collection.Length - 1];
            int j = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if (collection[i].Equals(item))
                    j = 1;

                temp[i] = collection[i + j];
            }

            collection = temp;
            return 0;
        }
    }
}
