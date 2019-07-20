using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Date
{
    class Date
    {
        public int Day;
        public int Month;
        public int Year;

        static Dictionary<string, byte> DaysInMonths = new Dictionary<string, byte>();

        enum MonthNumber : byte
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static Date()
        {
            DaysInMonths.Add("January", 31);
            DaysInMonths.Add("February", 28);
            DaysInMonths.Add("March", 31);
            DaysInMonths.Add("April", 30);
            DaysInMonths.Add("May", 31);
            DaysInMonths.Add("June", 30);
            DaysInMonths.Add("July", 31);
            DaysInMonths.Add("August", 31);
            DaysInMonths.Add("September", 30);
            DaysInMonths.Add("October", 31);
            DaysInMonths.Add("November", 30);
            DaysInMonths.Add("December", 31);
        }

        public Date(int day, int month, int year)
        {

            day = Math.Abs(day);
            month = Math.Abs(month);

            start:

            if (month > 12)
            {
                year++;
                month -= 12;
                goto start;
            }

            MonthNumber n = (MonthNumber)month;

            if (day > DaysInMonths[n.ToString()])
            {
                month++;
                day -= DaysInMonths[n.ToString()];
                goto start;
            }

            this.Day = day;
            this.Month = month;
            this.Year = year;

        }

        public static Date operator +(Date date, int days)
        {
            if (days < 0)
                return date - (new Date(days, 0, 0));
            else return new Date(days + date.Day, date.Month, date.Year);
        }

        public static Date operator -(Date date, int days)
        {
            return date - (new Date(days, 0, 0));
        }

        public static Date operator -(Date d1, Date d2)
        {
            int days = d1.Day - d2.Day;
            int month = d1.Month - d2.Month;
            int year = d1.Year - d2.Year;

            if (year < 0)
            {
                year *= -1;
                month *= -1;
                days *= -1;
            }

            if (month < 0)
            {
                year--;
                month = 12 + month;
            }

            if (days < 0)
            {
                month--;
                days = DaysInMonths[((MonthNumber)month).ToString()] + days;
            }

            return new Date(days, month, year);
        }

        public static Date operator +(Date d1, Date d2)
        {
            return new Date(d1.Day + d2.Day, d1.Month + d2.Month, d1.Year + d2.Year);
        }

        public override string ToString()
        {
            return "Date : " + Day + " / " + ((MonthNumber)Month).ToString() + " / " + Year;
        }
    }
}
