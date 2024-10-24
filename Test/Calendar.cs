using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Calendar
    {
        IList<string> daysOfWeek = new List<string>();

        public string dayName(int day)
        {
            return daysOfWeek[day - 1];
        }
    }
}
