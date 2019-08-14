using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomerAndCategoryCollection_V2
{
    class MagazineLog : IDictionary<Customer, ProductCategory>
    {
        public MagazineLog() { }

        public MagazineLog(KeyValuePair<Customer, ProductCategory> pair) { Add(pair); }

        public MagazineLog(Customer customer, ProductCategory category) { Add(customer, category); }

        KeyValuePair<Customer, ProductCategory>[] pairs = new KeyValuePair<Customer, ProductCategory>[0];

        public ProductCategory this[Customer customer]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                {
                    if (CustomerEquals(pairs[i].Key, customer))
                        return pairs[i].Value;
                }
                return default(ProductCategory);
            }

            set
            {
                if (Contains(customer))
                {
                    for (int i = 0; i < Count; i++)
                    {
                        if (CustomerEquals(pairs[i].Key, customer))
                            pairs[i] = new KeyValuePair<Customer, ProductCategory>(customer, value);
                    }
                }
                else
                {
                    Array.Resize(ref pairs, Count + 1);
                    pairs[Count - 1] = new KeyValuePair<Customer, ProductCategory>(customer, value);
                }
            }
        }

        public ICollection<Customer> Keys
        {
            get
            {
                Customer[] temp = new Customer[Count];
                for (int i = 0; i < Count; i++)
                {
                    temp[i] = pairs[i].Key;
                }
                return temp;
            }
        }

        public ICollection<ProductCategory> Values
        {
            get
            {
                ProductCategory[] temp = new ProductCategory[Count];
                for (int i = 0; i < Count; i++)
                {
                    temp[i] = pairs[i].Value;
                }
                return temp;
            }
        }

        public int Count => pairs.Length;

        public bool IsReadOnly => false;

        public void Add(Customer key, ProductCategory value)
        {
            if (Contains(new KeyValuePair<Customer, ProductCategory>(key, value)))
                return;

            Array.Resize(ref pairs, Count + 1);
            if (Contains(key))
            {
                for (int i = Count - 1; i >= 0; i--)
                {
                    if (i == 0 || CustomerEquals(pairs[i - 1].Key, key))
                    {
                        pairs[i] = new KeyValuePair<Customer, ProductCategory>(key, value);
                        return;
                    }
                    pairs[i] = pairs[i - 1];
                }
            }
            pairs[Count - 1] = new KeyValuePair<Customer, ProductCategory>(key, value);
        }

        public void Add(KeyValuePair<Customer, ProductCategory> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            pairs = new KeyValuePair<Customer, ProductCategory>[0];
        }

        public bool Contains(Customer key)
        {
            for (int i = 0; i < Count; i++)
            {
                if (CustomerEquals(pairs[i].Key, key))
                    return true;
            }

            return false;
        }

        public bool Contains(KeyValuePair<Customer, ProductCategory> item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (PairEquals(pairs[i], item))
                    return true;
            }
            return false;
        }

        public bool Contains(Customer key, ProductCategory value)
        {
            return Contains(new KeyValuePair<Customer, ProductCategory>(key, value));
        }

        public bool ContainsKey(Customer key)
        {
            return Contains(key);
        }

        public void CopyTo(KeyValuePair<Customer, ProductCategory>[] array, int arrayIndex)
        {
            if (array.Length < arrayIndex + pairs.Length + 1)
                Array.Resize(ref array, arrayIndex + pairs.Length + 1);

            for (int i = arrayIndex; i < pairs.Length + arrayIndex; i++)
            {
                array[i] = pairs[i - arrayIndex];
            }
        }

        public IEnumerator<KeyValuePair<Customer, ProductCategory>> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return pairs[i];
            }
            yield break;
        }

        public bool Remove(Customer key)
        {
            if (!Contains(key))
                return false;

            for (int i = 0; i < Count; i++)
            {
                if (CustomerEquals(pairs[i].Key, key))
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        pairs[j] = pairs[j + 1];
                    }
                    Array.Resize(ref pairs, Count - 1);
                    i--;
                }
            }
            return true;
        }

        public bool Remove(KeyValuePair<Customer, ProductCategory> item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (PairEquals(pairs[i], item))
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        pairs[j] = pairs[j + 1];
                    }
                    Array.Resize(ref pairs, Count - 1);
                    return true;
                }
            }
            return false;
        }

        public bool Remove(Customer customer, ProductCategory category)
        {
            return Remove(new KeyValuePair<Customer, ProductCategory>(customer, category));
        }

        public ProductCategory[] GetCategoriesByCustomer(Customer customer)
        {
            ProductCategory[] temp = new ProductCategory[0];
            for (int i = 0; i < Count; i++)
            {
                if (CustomerEquals(pairs[i].Key, customer))
                {
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = pairs[i].Value;
                }
            }
            return temp;
        }

        public Customer[] GetCustomersByProductCategory(ProductCategory category)
        {
            Customer[] temp = new Customer[0];
            for (int i = 0; i < Count; i++)
            {
                if (CategoryEquals(pairs[i].Value, category))
                {
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = pairs[i].Key;
                }
            }
            return temp;
        }

        public bool TryGetValue(Customer key, out ProductCategory value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (CustomerEquals(pairs[i].Key, key))
                {
                    value = pairs[i].Value;
                    return true;
                }
            }
            value = default(ProductCategory);
            return false;
        }

        private bool CustomerEquals(Customer c1, Customer c2)
        {
            if (c1 == null || c2 == null)
                return false;
            if (c1.GetHashCode() == c2.GetHashCode() && c1.Equals(c2))
                return true;
            else return false;
        }

        private bool CategoryEquals(ProductCategory c1, ProductCategory c2)
        {
            if (c1 == null || c2 == null)
                return false;
            if (c1.GetHashCode() == c2.GetHashCode() && c1.Equals(c2))
                return true;
            else return false;
        }

        private bool PairEquals(KeyValuePair<Customer, ProductCategory> p1, KeyValuePair<Customer, ProductCategory> p2)
        {
            if (CustomerEquals(p1.Key, p2.Key) && CategoryEquals(p1.Value, p2.Value))
                return true;
            else return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return pairs[i];
            }
            yield break;
        }
    }
}
