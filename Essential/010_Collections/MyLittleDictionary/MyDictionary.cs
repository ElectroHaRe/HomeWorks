using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyLittleDictionary
{
    class MyDictionary<Tkey,TValue>
    {
        private Tkey[] keys = new Tkey[0];
        private TValue[] values = new TValue[0];

        public int GetSize => keys.Length;

        public TValue this[Tkey key]
        {
            get
            {
                if (!keys.Contains(key))
                    return default(TValue);
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].Equals(key))
                        return values[i];
                }
                return default(TValue);
            }
            set
            {
                if (keys.Contains(key)) {
                    for (int i = 0; i < keys.Length; i++)
                    {
                        if (keys[i].Equals(key))
                            values[i] = value;
                    }
                }
            }
        }

        public void Add(Tkey key, TValue value) {
            Array.Resize(ref keys, keys.Length + 1);
            Array.Resize(ref values, values.Length + 1);
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public int Delete(Tkey key) {
            if (!keys.Contains(key))
                return 1;
            Tkey[] tempK = new Tkey[keys.Length - 1];
            TValue[] tempV = new TValue[values.Length - 1];

            int j = 0;
            for (int i = 0; i < tempK.Length; i++)
            {
                if (keys[i].Equals(key))
                    j++;
                tempK[i] = keys[i+j];
                tempV[i] = values[i + j];
            }

            keys = tempK;
            values = tempV;

            return 0;
        }
    }
}