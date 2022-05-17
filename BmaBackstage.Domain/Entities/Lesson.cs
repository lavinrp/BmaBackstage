using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    public class Lesson
    {
        public Lesson(IInstructor instructor, DateTime day)
        {
            Instructor = instructor;
            Day = day;
        }
        public IInstructor Instructor { get; private set; }
        public DateTime Day { get; private set; }
    }
}
