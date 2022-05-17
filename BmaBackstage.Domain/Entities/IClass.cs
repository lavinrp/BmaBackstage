using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    public interface IClass
    {
        List<IInstructor> HeadInstructors { get; set; }
        List<IInstructor> AssistantInstructors { get; set; }
        List<IStudent> Students { get; set; }
        List<DayOfWeek> DaysOfWeek { get; set; }
        TimeSpan TimeOfDay { get; set; }
        List<IProgressionArchetype> ProgressionArchetypes { get; set; }
        string Name { get; set; }
        IDojo Dojo { get; set; }
        List<Lesson> Lessons { get; set; }
    }
}
