using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class CountingSundays
    {
        public static int FindCountingSundays(int endYear)
        {
            int currDay = 1;    // 1 = Monday, 7 = Sunday
            int currYear = 1901;
            int numSundaysOnFirst = 0;
            int[] normalDays = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            while (currYear <= endYear)
            {
                for (int month = 0; month < normalDays.Length; month++)
                {
                    currDay += normalDays[month] - 1;
                    if (month == 1 && IsItALeapYear(year: currYear))
                    {
                        currDay++;
                    }
                    if (currDay % 7 == 0)
                    {
                        numSundaysOnFirst++;
                    }
                }
                currYear++;
            }

            return numSundaysOnFirst;
        }

        private static bool IsItALeapYear(int year)
        {
            /**
             * A year is a leap year if hte year is divisible by 4, but not on a century, unless it is divisible by
             * 400.
             */
            if (year % 4 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }

                if (year % 100 == 0)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        public static int FindCountingSundaysEasy(int endYear)
        {
            DateTime currDate = new DateTime(year: 1901, month: 1, day: 1);
            DateTime endDate = new DateTime(year: endYear, month: 12, day: 31);
            int numSundaysOnFirst = 0;
            while (currDate <= endDate)
            {
                if (currDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    numSundaysOnFirst++;
                }
                currDate = currDate.AddMonths(months: 1);
            }

            return numSundaysOnFirst;
        }
    }
}
