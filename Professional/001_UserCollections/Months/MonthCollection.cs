using System;
using System.Collections;
using System.Collections.Generic;
namespace Months
{
    struct Month
    {
        public Month(string name, int dayCount)
        {
            this.Name = name;
            this.daysCount = dayCount;
        }

        public readonly string Name;
        public readonly int daysCount;

        public override string ToString()
        {
            return "Month : " + Name + " | days : " + daysCount;
        }
    }

    class MonthCollection : IEnumerable<Month>, IEnumerator<Month>
    {
        private Month[] array = new Month[12] { new Month("January", 31), new Month("February",28),new Month("March",31),
                                                new Month("April",30), new Month("May",31), new Month("June",30),
                                                new Month("July",31), new Month("August",31), new Month("September",30),
                                                new Month("October",31), new Month("November",30), new Month("December",31)};

        public Month this[int monthNumber]
        {
            get
            {
                monthNumber--;
                if (monthNumber < Count && monthNumber >= 0)
                    return array[monthNumber];
                else return default(Month);
            }
        }

        public int GetDaysByMonth(string monthName)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Name == monthName)
                    return array[i].daysCount;
            }
            return 0;
        }

        public Month[] GetMonthsByDays(int days)
        {
            Month[] temp = new Month[0];
            for (int i = 0; i < Count; i++)
            {
                if (array[i].daysCount == days)
                {
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = array[i];
                }
            }
            return temp;
        }

        public int position { get; private set; } = -1;

        public int Count => array.Length;

        public Month Current => array[position];

        object IEnumerator.Current => array[position];

        public IEnumerator<Month> GetEnumerator()
        {
            return this as IEnumerator<Month>;
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}
