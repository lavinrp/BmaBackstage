using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel.Progressions.Requirements
{
    public class AttendanceRequirement : Requirement
    {
        public required List<Lesson> Lessons { get; set; }
        public required int RequiredLessonCount { get; set; }
    }
}
