using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel
{
    /// <summary>
    /// Records time worked in a single day
    /// </summary>
    public class TimeSheetEntry
    {
        /// <summary>
        /// Day that the work took place
        /// </summary>
        public required DateTime Day { get; set; }

        /// <summary>
        /// Duration of the work
        /// </summary>
        public required TimeSpan Duration { get; set; }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public required Guid Id { get; set; }
    }
}
