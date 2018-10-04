using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateComparer
{
    public class DateModel
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public DateModel(string date)
        {
            int yr, mon, day;
            var dateArr = date.Split('/');
            if(int.TryParse(dateArr[2], out yr))
            {
                Year = yr;
            }
            if (int.TryParse(dateArr[1], out mon))
            {
                Month = mon;
            }
            if (int.TryParse(dateArr[0], out day))
            {
                Day = day;
            }
        }
    }
}
