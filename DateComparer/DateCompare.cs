using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DateComparer
{
    public class DateCompare
    {
        
        private static DateModel FromDate { get; set; }
        private static DateModel ToDate { get; set; }
        
        //This method is used to check the date string is in dd/MM/yyyy format
        public static bool IsValidDateString(string date)
        {
            Regex regx = new Regex("^(?=\\d{2}([\\/])\\d{2}\\1\\d{4}$)(?:0[1-9]|1\\d|[2][0-8]|29(?!.02.(?!(?!(?:[02468][1-35-79]|[13579][0-13-57-9])00)\\d{2}(?:[02468][048]|[13579][26])))|30(?!.02)|31(?=.(?:0[13578]|10|12))).(?:0[1-9]|1[012]).\\d{4}$"
);
            return regx.IsMatch(date);
        }

        //This method is used to check if from date is less than to date
        public static bool IsFromDateLessThanToDate(string fromDateString, string toDateString)
        {
            if(!(IsValidDateString(fromDateString) && IsValidDateString(toDateString)))
            {
                throw new Exception("Invalid Date");
            }
            FromDate = new DateModel(fromDateString);
            ToDate = new DateModel(toDateString);
            var dateHelper = new DateHelper(FromDate, ToDate);
            return dateHelper.IsFromDateLessThanToDate();
        }
        
        //This method is used to get the difference of days from fromDate string and toDate string.
        public static int GetDifference(string fromDateString, string toDateString)
        {
            if (!(IsValidDateString(fromDateString) && IsValidDateString(toDateString)))
            {
                throw new Exception("Invalid Date");
            }
            FromDate = new DateModel(fromDateString);
            ToDate = new DateModel(toDateString);
            var dateHelper = new DateHelper(FromDate, ToDate);
            return dateHelper.GetDifference();
            
        }
    }
}
