using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days
{
    public class EnumDays
    {
        public int this [string day]
        {

            get
            {
                if (day == DayOfWeek.Monday.ToString() || day == DayOfWeek.Friday.ToString() 
                    || day == DayOfWeek.Saturday.ToString() || day == DayOfWeek.Sunday.ToString() 
                    || day == DayOfWeek.Thursday.ToString() || day == DayOfWeek.Tuesday.ToString() 
                    || day == DayOfWeek.Wednesday.ToString())
                    return (int)(DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
                else throw new Exception("The string is not day of week");
            }
        }

    }
}
