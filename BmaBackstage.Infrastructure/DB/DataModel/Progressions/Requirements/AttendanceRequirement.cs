using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel.Progressions.Requirements
{
    internal class AttendanceRequirement : Requirement
    {
        public required List<Lesson> Lessons { get; set; }
        public required int RequiredLessonCount { get; set; }
    }
}
