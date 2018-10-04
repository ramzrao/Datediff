using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateComparer
{
    public class DateHelper
    {
        public DateModel FromDate { get; set; }
        public DateModel ToDate { get; set; }

        public DateHelper(DateModel fromDate,DateModel toDate)
        {
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }

        //This method checks the provided year is leap year or not.
        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
        }

        //This method increases from date by 1.
        private void IncreaseDate()
        {
            if (IsLastDayInAMonth(FromDate.Year, FromDate.Month, FromDate.Day))
            {
                if (FromDate.Month == 12)
                {
                    FromDate.Month = 1;
                    FromDate.Day = 1;
                    FromDate.Year++;
                }
                else
                {
                    FromDate.Day = 1;
                    FromDate.Month++;
                }
            }
            else
            {
                FromDate.Day++;
            }
        }
        
        //This method checks if the provided input is last day of the month
        private bool IsLastDayInAMonth(int year, int month, int day)
        {
            int[] numOfDaysPerMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year) && month == 2)
            {
                return (day == 29);
            }
            else
            {
                return (numOfDaysPerMonth[month - 1] == day);
            }
        }

        public bool IsFromDateLessThanToDate()
        {
            return (FromDate.Year < ToDate.Year ? true :
                   (FromDate.Year == ToDate.Year ? (FromDate.Month < ToDate.Month ? true :
                   (FromDate.Month == ToDate.Month ? FromDate.Day < ToDate.Day : false)) : false));
        }

        //This method increments from day until fromdate is less than todate. 
        // While incrementing it counts number of times the date has been incremented.
        public int GetDifference()
        {
            int days = 0;
            while (IsFromDateLessThanToDate())
            {
                days++;
                IncreaseDate();
            }

            return days;
        }

    }
}
