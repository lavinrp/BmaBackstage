using BmaBackstage.Infrastructure.DB.DataModel.Progressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel.People
{
    internal class Student : Person
    {
        public List<StudentContract>? Contracts {get; set; }
        public List<string>? SpecialNeeds { get; set; }
        public List<string>? Notes { get; set; }
        public virtual List<Progression>? Progressions { get; set; }
    }
}
