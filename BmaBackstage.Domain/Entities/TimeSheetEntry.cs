using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Records time worked in a single day
    /// </summary>
    public class TimeSheetEntry
    {
        /// <summary>
        /// Construct a TimeSheetEntry for a specified day with a specified duration of work
        /// </summary>
        /// <param name="day"></param>
        /// <param name="duration"></param>
        public TimeSheetEntry(DateTime day, TimeSpan duration)
        {
            Day = day;
            Duration = duration;
        }

        /// <summary>
        /// Day that the work took place
        /// </summary>
        public DateTime Day { get; private set; }

        /// <summary>
        /// Duration of the work
        /// </summary>
        public TimeSpan Duration { get; private set; }
    }
}
