using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _017_LINQ
{
    class BuyerCollection : IEnumerable<BuyerCollection.Buyer>, IEnumerator<BuyerCollection.Buyer>
    {
        public class Buyer
        {
            public Buyer(string carModel, string name, string phoneNumber)
            {
                CarModel = carModel;
                Name = name;
                PhoneNumber = phoneNumber;

                for (int i = 0; i < buyers.Length; i++)
                {
                    if (buyers[i].CarModel == carModel && buyers[i].Name == name && buyers[i].PhoneNumber == phoneNumber)
                    {
                        id = buyers[i].GetHashCode();
                    }
                }

                id = this.GetHashCode();
                Array.Resize(ref buyers, buyers.Length + 1);
                buyers[buyers.Length - 1] = this;
            }

            private static Buyer[] buyers = new Buyer[0];

            private int id;


            public readonly string CarModel;
            public readonly string Name;
            public readonly string PhoneNumber;

            public override bool Equals(object obj) => obj.GetHashCode() == this.GetHashCode();

            public override int GetHashCode() => id;

            public override string ToString()
            {
                return "name : " + Name + " | car model : " + CarModel + " | phone : " + PhoneNumber;
            }
        }

        private Buyer[] collection = new Buyer[0];

        public int size => collection.Length;

        public Buyer this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                    return null;
                else return collection[index];
            }
        }

        public Buyer[] this[Predicate<Buyer> predicate]
        {
            get
            {
                Buyer[] temp = new Buyer[0];
                for (int i = 0; i < size; i++)
                {
                    if (predicate(collection[i]))
                    {
                        Array.Resize(ref temp, temp.Length + 1);
                        temp[temp.Length - 1] = collection[i];
                    }
                }
                return temp;
            }
        }

        public void Add(Buyer item)
        {
            Array.Resize(ref collection, size + 1);
            collection[size - 1] = item;
        }

        public void Add(params Buyer[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Add(items[i]);
            }
        }

        public void Add(string carModel, string name, string phoneNumber)
        {
            Add(new Buyer(carModel, name, phoneNumber));
        }

        public bool Delete(Buyer item)
        {
            if (!collection.Contains(item))
                return false;

            Buyer[] temp = new Buyer[size - 1];
            int j = 0;
            for (int i = 0; i < size-1; i++)
            {
                if (collection[i].Equals(item))
                    j = 1;
                temp[i] = collection[j];
            }

            collection = temp;

            return true;
        }

        public bool Delete(string carModel, string name, string phoneNumber) => Delete(new Buyer(carModel, name, phoneNumber));

        public void Delete(params Buyer[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Delete(items[i]);
            }
        }

        // // // // // // // // // // // // // // // // // //

        public int position { get; private set; } = -1;

        Buyer IEnumerator<Buyer>.Current
        {
            get
            {
                if (position < 0 || position >= size)
                    return null;
                else return collection[position];
            }
        }

        object IEnumerator.Current => ((IEnumerator<Buyer>)this).Current;

        IEnumerator<Buyer> IEnumerable<Buyer>.GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        void IDisposable.Dispose()
        {
        }

        bool IEnumerator.MoveNext()
        {
            if (position < size - 1)
            {
                position++;
                return true;
            }
            else
            {
                ((IEnumerator<Buyer>)this).Reset();
                return false;
            }
        }

        void IEnumerator.Reset()
        {
            position = -1;
        }
    }
}
