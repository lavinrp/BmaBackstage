using BmaBackstage.Infrastructure.DB.DataModel.Progressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel.People
{
    public class Instructor : Person
    {
        public DateTime? LastSafeSportTestDate { get; set; }
        public DateTime? LastBackgroundCheckDate { get; set; }
        public virtual List<TimeSheetEntry>? TimeSheet { get; set; }
        public virtual List<Progression>? Progressions { get; set; }
    }
}
