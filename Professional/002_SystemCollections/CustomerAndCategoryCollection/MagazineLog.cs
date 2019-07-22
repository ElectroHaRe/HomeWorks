using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomerAndCategoryCollection
{
    class MagazineLog : IDictionary<Customer, ProductCategory>
    {
        private class CustomerProducts : IEnumerable<ProductCategory>, IEnumerator<ProductCategory>
        {
            public CustomerProducts(Customer customer)
            {
                this.customer = customer;
            }

            public CustomerProducts(Customer customer, ProductCategory category) : this(customer)
            {
                AddCategory(category);
            }

            public CustomerProducts(Customer customer, params ProductCategory[] categories) : this(customer)
            {
                AddCategories(categories);
            }

            public Customer customer;

            public ProductCategory[] CategoriesOfProducts = new ProductCategory[0];

            private bool Contains(ProductCategory category)
            {
                for (int i = 0; i < CategoriesOfProducts.Length; i++)
                {
                    if (CategoriesOfProducts[i].GetHashCode() == category.GetHashCode() && CategoriesOfProducts[i].Equals(category))
                        return true;
                }
                return false;
            }

            private bool Contains(string category_name, int categoty_id)
            {
                return Contains(new ProductCategory(category_name, categoty_id));
            }

            public bool AddCategory(ProductCategory category)
            {
                if (Contains(category))
                    return false;

                Array.Resize(ref CategoriesOfProducts, CategoriesOfProducts.Length + 1);
                CategoriesOfProducts[CategoriesOfProducts.Length - 1] = category;
                return true;
            }

            public bool AddCategory(string category_name, int categoty_id)
            {
                return AddCategory(new ProductCategory(category_name, categoty_id));
            }

            public void AddCategories(params ProductCategory[] categories)
            {
                for (int i = 0; i < categories.Length; i++)
                {
                    AddCategory(categories[i]);
                }
            }

            public bool DeleteCategory(ProductCategory category)
            {
                if (!Contains(category))
                    return false;

                for (int i = 0; i < CategoriesOfProducts.Length; i++)
                {
                    if (CategoriesOfProducts[i].GetHashCode() == category.GetHashCode() && CategoriesOfProducts[i].Equals(category))
                    {
                        for (int j = i; j < CategoriesOfProducts.Length - 1; j++)
                        {
                            CategoriesOfProducts[j] = CategoriesOfProducts[j + 1];
                        }
                        break;
                    }
                }

                Array.Resize(ref CategoriesOfProducts, CategoriesOfProducts.Length - 1);
                return true;
            }

            public bool DeleteCategoty(string category_name, int categoty_id)
            {
                return DeleteCategory(new ProductCategory(category_name, categoty_id));
            }

            public void DeleteCategories(params ProductCategory[] categories)
            {
                for (int i = 0; i < categories.Length; i++)
                {
                    DeleteCategory(categories[i]);
                }
            }

            //Реализация интерфейса IEnumerable<ProductCategory>

            IEnumerator<ProductCategory> IEnumerable<ProductCategory>.GetEnumerator()
            {
                return this;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this;
            }

            //Реализация интерфейса IEnumerator<ProductCategory>

            int position = -1;

            ProductCategory IEnumerator<ProductCategory>.Current => CategoriesOfProducts[position];

            object IEnumerator.Current => CategoriesOfProducts[position];

            void IDisposable.Dispose()
            {
                (this as IEnumerator).Reset();
            }

            bool IEnumerator.MoveNext()
            {
                if (position < CategoriesOfProducts.Length)
                {
                    position++;
                    return true;
                }
                return false;
            }

            void IEnumerator.Reset()
            {
                position = -1;
            }
        }

        private CustomerProducts[] collection = new CustomerProducts[0];

        public ICollection<Customer> Keys
        {
            get
            {
                Customer[] temp = new Customer[0];
                for (int i = 0; i < Count; i++)
                {
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = collection[i].customer;
                }
                return temp;
            }
        }

        public ICollection<ProductCategory> Values
        {
            get
            {
                ProductCategory[] temp = new ProductCategory[0];
                for (int i = 0; i < Count; i++)
                {
                    for (int j = 0; j < collection[i].CategoriesOfProducts.Length; j++)
                    {
                        if (!temp.Contains(collection[i].CategoriesOfProducts[j]))
                        {
                            Array.Resize(ref temp, temp.Length + 1);
                            temp[temp.Length - 1] = collection[i].CategoriesOfProducts[j];
                        }
                    }
                }
                return temp;
            }
        }

        public int Count => collection.Length;

        public bool IsReadOnly => false;

        public ProductCategory this[Customer key]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                {
                    if (collection[i].customer.GetHashCode() == key.GetHashCode() && collection[i].customer.Equals(key) && collection[i].CategoriesOfProducts.Length > 0)
                        return collection[i].CategoriesOfProducts[0];
                }
                return default(ProductCategory);
            }
            set
            {
                for (int i = 0; i < Count; i++)
                {
                    if (collection[i].customer.GetHashCode() == key.GetHashCode() && collection[i].customer.Equals(key))
                        collection[i].AddCategory(value);
                }
            }
        }

        public bool ContainsKey(Customer key)
        {
            for (int i = 0; i < Count; i++)
            {
                if (collection[i].customer.GetHashCode() == key.GetHashCode() && collection[i].customer.Equals(key))
                    return true;
            }
            return false;
        }

        public void Add(Customer key, ProductCategory value)
        {
            if (ContainsKey(key))
            {
                this[key] = value;
                return;
            }

            Array.Resize(ref collection, Count + 1);
            collection[Count - 1] = new CustomerProducts(key, value);
        }

        public bool Remove(Customer key)
        {
            for (int i = 0; i < Count; i++)
            {
                if (CustomerEquals(collection[i].customer, key))
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        collection[j] = collection[j + 1];
                    }
                    Array.Resize(ref collection, Count - 1);
                    return true;
                }
            }
            return false;
        }

        public bool TryGetValue(Customer key, out ProductCategory value)
        {
            value = this[key];
            if (CategoriesEquals(value, default(ProductCategory)))
                return true;
            else return false;

        }

        public void Add(KeyValuePair<Customer, ProductCategory> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            collection = new CustomerProducts[0];
        }

        public bool Contains(KeyValuePair<Customer, ProductCategory> item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (CustomerEquals(item.Key, collection[i].customer))
                {
                    for (int j = 0; j < collection[i].CategoriesOfProducts.Length; j++)
                    {
                        if (CategoriesEquals(collection[i].CategoriesOfProducts[j], item.Value))
                            return true;
                    }
                }
            }
            return false;
        }

        public KeyValuePair<Customer, ProductCategory>[] GetPairArray()
        {
            KeyValuePair<Customer, ProductCategory>[] temp = new KeyValuePair<Customer, ProductCategory>[0];
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < collection[i].CategoriesOfProducts.Length; j++)
                {
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = new KeyValuePair<Customer, ProductCategory>(collection[i].customer, collection[i].CategoriesOfProducts[j]);
                }
            }
            return temp;
        }

        public void CopyTo(KeyValuePair<Customer, ProductCategory>[] array, int arrayIndex)
        {
            KeyValuePair<Customer, ProductCategory>[] temp = GetPairArray();
            for (int i = arrayIndex; i < array.Length; i++)
            {
                if (i - arrayIndex < temp.Length)
                    array[i] = temp[i - arrayIndex];
                else break;
            }
        }

        public bool Remove(KeyValuePair<Customer, ProductCategory> item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (CustomerEquals(collection[i].customer, item.Key) && collection[i].CategoriesOfProducts.Length > 0)
                {
                    for (int j = 0; j < collection[i].CategoriesOfProducts.Length; j++)
                    {
                        if (CategoriesEquals(item.Value, collection[i].CategoriesOfProducts[j]))
                        {
                            for (int k = j; k < collection[i].CategoriesOfProducts.Length - 1; k++)
                            {
                                collection[i].CategoriesOfProducts[k] = collection[i].CategoriesOfProducts[k + 1];
                            }
                            Array.Resize(ref collection[i].CategoriesOfProducts, collection[i].CategoriesOfProducts.Length - 1);
                        }
                    }
                    if (collection[i].CategoriesOfProducts.Length == 0)
                        Remove(collection[i].customer);
                    return true;
                }
            }
            return false;
        }

        private bool CustomerEquals(Customer c1, Customer c2)
        {
            if (((object)c1) == null || ((object)c2) == null)
                return false;
            if (c1.GetHashCode() == c2.GetHashCode() && c1.Equals(c2))
                return true;
            else return false;
        }

        private bool CategoriesEquals(ProductCategory c1, ProductCategory c2)
        {
            if (((object)c1) == null || ((object)c2) == null)
                return false;
            if (c1.GetHashCode() == c2.GetHashCode() && c1.Equals(c2))
                return true;
            else return false;
        }

        public IEnumerator<KeyValuePair<Customer, ProductCategory>> GetEnumerator()
        {
            var temp = GetPairArray();
            for (int i = 0; i < temp.Length; i++)
            {
                yield return temp[i];
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var temp = GetPairArray();
            for (int i = 0; i < temp.Length; i++)
            {
                yield return temp[i];
            }
            yield break;
        }
    }
}
