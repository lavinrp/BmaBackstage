using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    class TimeSheetEntry
    {
        public TimeSheetEntry(DateTime day, TimeSpan duration)
        {
            Day = day;
            Duration = duration;
        }
        public DateTime Day { get; private set; }
        public TimeSpan Duration { get; private set; }
    }
}
