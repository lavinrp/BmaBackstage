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
    public class TimeSheetEntry : IEntity
    {
        /// <summary>
        /// Day that the work took place
        /// </summary>
        public DateTime Day { get; set; }

        /// <summary>
        /// Duration of the work
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
