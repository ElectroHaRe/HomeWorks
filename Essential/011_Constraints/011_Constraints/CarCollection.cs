using System;
using System.Linq;

namespace _011_Constraints
{
    class CarCollection<T> where T : ICar
    {
        ICar[] carArray = new ICar[0];

        public int this[T item]
        {
            get
            {
                for (int i = 0; i < carArray.Length; i++)
                {
                    if (carArray[i].Equals(item))
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < carArray.Length)
                {
                    return (T)carArray[index];
                }
                else return default(T);
            }
            set
            {
                if (index >= 0 && index < carArray.Length)
                {
                    carArray[index] = value;
                }
            }
        }

        public T[] this[string name] {
            get
            {
                T[] temp = new T[0];
                for (int i = 0; i < carArray.Length; i++)
                {
                    if (carArray[i].Name == name)
                    {
                        Array.Resize(ref temp, temp.Length + 1);
                        temp[temp.Length - 1] = (T)carArray[i];
                    }
                }
                return temp;
            }
        }

        public T[] this[uint Year]
        {
            get
            {
                T[] temp = new T[0];
                for (int i = 0; i < carArray.Length; i++)
                {
                    if (carArray[i].Year == Year)
                    {
                        Array.Resize(ref temp, temp.Length + 1);
                        temp[temp.Length - 1] = (T)carArray[i];
                    }
                }
                return temp;
            }
        }

        public int Size => carArray.Length;

        public int Replace(T item, T replace)
        {
            for (int i = 0; i < carArray.Length; i++)
            {
                if (carArray[i].Equals(item))
                {
                    carArray[i] = replace;
                    return 0;
                }
            }
            return 1;
        }

        public void Add(T item)
        {
            Array.Resize(ref carArray, carArray.Length + 1);
            carArray[carArray.Length - 1] = item;
        }

        public int Delete(T item) {
            if (!carArray.Contains(item))
                return 1;

            ICar[] temp = new ICar[carArray.Length - 1];

            int j = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (carArray[i].Equals(item))
                    j++;
                temp[i] = carArray[i + j];
            }
            carArray = temp;
            return 0;
        }

        public void SortByYear()
        {
            ICar buf = null;
            for (int i = 0; i < carArray.Length; i++)
            {
                for (int j = 0; j < carArray.Length; j++)
                {
                    if (i > j && carArray[i].Year < carArray[j].Year) {
                        buf = carArray[i];
                        carArray[i] = carArray[j];
                        carArray[j] = buf;
                    }
                }
            }
        }
    }
}
