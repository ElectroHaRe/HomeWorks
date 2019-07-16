using System;
using System.Linq;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] key_array = new Tkey[0];
        Tvalue[] value_array = new Tvalue[0];

        public Tvalue this[Tkey key]
        {
            get
            {
                if (!key_array.Contains(key))
                    return default(Tvalue);

                for (int i = 0; i < key_array.Length; i++)
                {
                    if (key_array[i].Equals(key))
                        return value_array[i];
                }

                return default(Tvalue);
            }
            set
            {
                if (key_array.Contains(key))
                {
                    for (int i = 0; i < key_array.Length; i++)
                    {
                        if (key_array[i].Equals(key))
                            value_array[i] = value;
                    }
                }
                else
                {
                    Add(key, value);
                }
            }
        }

        public Tkey[] GetKeyList => key_array;

        public Tvalue[] GetValueList => value_array;

        public int size => key_array.Length;

        public void Add(Tkey key,Tvalue value)
        {
            Array.Resize(ref key_array, key_array.Length + 1);
            Array.Resize(ref value_array, value_array.Length + 1);

            key_array[key_array.Length - 1] = key;
            value_array[value_array.Length - 1] = value;
        }

        public int Delete(Tkey key) {
            if (!key_array.Contains(key))
                return 0;

            Tkey[] tempK = new Tkey[key_array.Length - 1];
            Tvalue[] tempV = new Tvalue[value_array.Length - 1];

            int j = 0;
            for (int i = 0; i < tempK.Length; i++)
            {
                if (key_array[i].Equals(key))
                    j = 1;
                tempK[i] = key_array[i + j];
                tempV[i] = value_array[i + j];
            }

            key_array = tempK;
            value_array = tempV;

            return 0;
        }
    }
}
