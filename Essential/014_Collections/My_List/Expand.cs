using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_List
{
    static class Expand
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] temp = new T[0];
            foreach (T item in list)
            {
                Array.Resize(ref temp, temp.Length + 1);
                temp[temp.Length - 1] = item;
            }
            return temp;
        }
    }
}
