using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace My_Dictionary
{
    class MyDictionary<Tkey, Tvalue> : IEnumerable<Tkey>, IEnumerator<Tkey>
    {
        public MyDictionary() { }
        public MyDictionary(Tkey key, Tvalue value) { Add(key, value); }

        public int position { get; private set; } = -1;
        public int size => _key.Length;

        private Tkey[] _key = new Tkey[0];
        private Tvalue[] _value = new Tvalue[0];

        public Tvalue this[Tkey key]
        {
            get
            {
                if (_key.Contains(key))
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (_key[i].Equals(key))
                            return _value[i];
                    }
                }
                return default(Tvalue);
            }
        }

        public bool Add(Tkey k, Tvalue v)
        {
            if (_key.Contains(k))
                return false;

            Array.Resize(ref _key, size + 1);
            Array.Resize(ref _value, size + 1);

            _key[size - 1] = k;
            _value[size - 1] = v;

            ((IEnumerator)this).Reset();

            return true;
        }

        public bool Delete(Tkey k)
        {
            if (!_key.Contains(k))
                return false;

            Tkey[] temp_k = new Tkey[size - 1];
            Tvalue[] temp_v = new Tvalue[size - 1];
            int j = 0;
            for (int i = 0; i < size - 1; i++)
            {
                if (_key[i].Equals(k))
                    j = 1;
                temp_k[i] = _key[i + j];
                temp_v[i] = _value[i + j];
            }

            _key = temp_k;
            _value = temp_v;

            ((IEnumerator)this).Reset();

            return true;
        }

        public void Delete(params Tkey[] keys)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Delete(keys[i]);
            }
        }

        public void ClearDictionary()
        {
            _key = new Tkey[0];
            _value = new Tvalue[0];
        }

        Tkey IEnumerator<Tkey>.Current
        {
            get
            {
                if (position >= 0 && position < size)
                    return _key[position];
                else return default(Tkey);
            }
        }

        object IEnumerator.Current => ((IEnumerator<Tvalue>)this).Current;

        void IDisposable.Dispose()
        {
        }

        IEnumerator<Tkey> IEnumerable<Tkey>.GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        bool IEnumerator.MoveNext()
        {
            if (position < size - 1)
                position++;
            else return false;

            return true;
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
