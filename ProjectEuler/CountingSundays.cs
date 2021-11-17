using System;
using System.Collections.Generic;
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
            int currYear = 1900;
            int numSundaysOnFirst = 0;
            int[] normalDays = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] leapYearDays = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            while (currYear <= 2000)
            {
                for (int month = 0; month < normalDays.Length; month++)
                {

                }
                currYear++;
            }

            throw new NotImplementedException();
            return numSundaysOnFirst;
        }

        private bool IsItALeapYear(int year)
        {
            throw new NotImplementedException();
        }
    }
}
