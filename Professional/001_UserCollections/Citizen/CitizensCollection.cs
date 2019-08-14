using System;
using System.Collections;
using System.Collections.Generic;

namespace Citizen
{
    class CitizensCollection : ICollection<Citizen>
    {
        private Citizen[] citizens = new Citizen[0];

        public int Count => citizens.Length;

        public bool IsReadOnly => false;

        public int Add(Citizen item)
        {
            if (Contains(item))
                return -1;

            (this as ICollection<Citizen>).Add(item);

            for (int i = 0; i < Count; i++)
            {
                if (citizens[i] == item)
                    return i;
            }

            return -1;
        }

        void ICollection<Citizen>.Add(Citizen item)
        {
            if (Contains(item))
                return;

            Array.Resize(ref citizens, Count + 1);

            if (item is Pensioner)
            {
                for (int i = Count - 1; i >= 0; i--)
                {
                    if (i == 0 || citizens[i - 1] is Pensioner)
                    {
                        citizens[i] = item;
                        break;
                    }
                    citizens[i] = citizens[i - 1];
                }
            }
            else citizens[Count - 1] = item;

        }

        public void Clear()
        {
            citizens = new Citizen[0];
        }

        public bool Contains(Citizen item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (citizens[i] == item)
                    return true;
            }
            return false;
        }

        public bool Contains(Citizen item, out int itemPosition)
        {
            itemPosition = -1;
            for (int i = 0; i < Count; i++)
            {
                if (citizens[i] == item)
                    itemPosition = i;
            }
            return Contains(item);
        }

        public void CopyTo(Citizen[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i < array.Length; i++)
            {
                if (i - arrayIndex < Count)
                    array[i] = citizens[i - arrayIndex];
                else break;
            }
        }

        public bool Delete(Citizen item)
        {
            if (!Contains(item))
                return false;

            for (int i = 0; i < Count-1; i++)
            {
                if (citizens[i] == item)
                {
                    for (int j = i; j < Count-1; j++)
                    {
                        citizens[j] = citizens[j + 1];
                    }
                    break;
                }
            }

            Array.Resize(ref citizens, Count - 1);

            return true;
        }

        public Citizen DeleteFirst()
        {
            if (Count == 0)
                return null;
            Citizen buf = citizens[0];
            Delete(buf);
            return buf;
        }

        public Citizen ReturnLast(out int pos)
        {
            pos = Count - 1;
            return citizens[pos];
        }

        public Citizen ReturnLast()
        {
            return citizens[Count-1];
        }

        public IEnumerator<Citizen> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return citizens[i];
            }
            yield break;
        }

        public bool Remove(Citizen item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (citizens[i] == item)
                {
                    citizens[i] = item;
                    return true;
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return citizens[i];
            }
            yield break;
        }
    }
}
